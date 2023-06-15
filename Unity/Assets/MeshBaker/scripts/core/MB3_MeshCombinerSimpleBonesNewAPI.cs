using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Collections;
using UnityEngine;


namespace DigitalOpus.MB.Core 
{
    public partial class MB3_MeshCombinerSingle : MB3_MeshCombiner
    {

#if UNITY_2019_1_OR_NEWER
        /// <summary>
        /// This class is responsible for managing skinned mesh data (bones, boneweights, bindposes) when combining skinned meshes and MeshRenderer meshes
        /// About the source data:
        ///    Some data comes from the source mesh (bindPoses, boneweights). We can retrieve these once and cache them
        ///    Some data comes from the renderer (bones array). There is a 1-to-1     dgo <--> SourceRenderer
        /// 
        /// Possible Situations:
        ///    We could be combining different characters with completely independant bone hierarchys'
        ///    We could be combining body parts on the same rig. These bone arrays will be subsets of a master list of bones. These subsets may overlap.
        ///    Input could be a mix of skinnedMeshRenderers and MeshRenderers
        ///    We may be use the noNewBonesForMeshRenderers feature where MeshRenderers that are children of other bones will use that bone as a parent
        ///
        /// </summary>
        public class MB_MeshCombinerSimpleBonesNewAPI : MB_IMeshCombinerSimpleBones
        {
            private bool _initialized = false;
            private bool _disposed = false;
            private MB3_MeshCombinerSingle combiner;
            private HashSet<BoneAndBindpose> bonesToAddAndInCombined;
            private List<BoneAndBindpose> masterList = new List<BoneAndBindpose>();
            private Matrix4x4[] nBindPoses;
            private Transform[] nbones;
            private int boneWeightSize;
            private int targBoneWeightIdx;

            private Dictionary<MB_DynamicGameObject, int> dgo2firstIdxInBoneWeightsArray = new Dictionary<MB_DynamicGameObject, int>();

            private NativeArray<byte> bonesPerVertex_nvarr;
            private NativeArray<BoneWeight1> boneWeight1s_nvarr;

            public MB_MeshCombinerSimpleBonesNewAPI(MB3_MeshCombinerSingle cm)
            {
                targBoneWeightIdx = 0;
                boneWeightSize = 0;
                combiner = cm;
            }

            public int GetNewBonesSize()
            {
                return masterList.Count;
            }

            public void BuildBoneIdx2DGOMapIfNecessary(int[] _goToDelete)
            {
                _initialized = false;
                masterList.Clear();

                if (combiner.settings.renderType == MB_RenderType.skinnedMeshRenderer)
                {
                    _initialized = true;
                }
            }

            public void RemoveBonesForDgosWeAreDeleting(MB_DynamicGameObject dgo)
            {
                // Intentionally empty. 
            }

            public bool GetCachedSMRMeshData(MB_DynamicGameObject dgo)
            {
                bool success = true;
                Debug.Assert(_initialized && !_disposed, "Need to setup first.");
                Debug.Assert(combiner.settings.renderType == MB_RenderType.skinnedMeshRenderer);
                // We could be working with adding and deleting smr body parts from the same rig. Different smrs will share 
                // the same bones.
                //cache the bone data that we will be adding.
                Renderer r = dgo._renderer;
                dgo._tmpSMR_CachedBindposes = combiner._meshChannelsCache.GetBindposes(r, out dgo.isSkinnedMeshWithBones);
                dgo._tmpSMR_CachedBoneWeightData = combiner._meshChannelsCache.GetBoneWeightData(r, dgo._tmpSMR_CachedBindposes.Length, dgo.isSkinnedMeshWithBones);
                dgo.numBoneWeights = dgo._tmpSMR_CachedBoneWeightData.boneWeights.Length;
                Debug.Assert(dgo._tmpSMR_CachedBoneWeightData.bonesPerVertex.Length > 0 && dgo._tmpSMR_CachedBoneWeightData.boneWeights.Length > 0);

                Transform[] dgoBones = dgo._tmpSMR_CachedBones = combiner._getBones(r, dgo.isSkinnedMeshWithBones);
                dgo._tmpSMR_CachedBoneAndBindPose = new BoneAndBindpose[dgoBones.Length];

                for (int i = 0; i < dgoBones.Length; i++)
                {
                    if (dgoBones[i] == null)
                    {
                        Debug.LogError("Source mesh r had a 'null' bone. Bones must not be null: " + r);
                        success = false;
                    }
                }

                if (combiner.settings.smrNoExtraBonesWhenCombiningMeshRenderers)
                {
                    for (int i = 0; i < dgoBones.Length; i++)
                    {
                        BoneAndBindpose bbp = new BoneAndBindpose(dgoBones[i], dgo._tmpSMR_CachedBindposes[i]);
                        bonesToAddAndInCombined.Add(bbp);
                    }
                }

                return success;
            }

            public void AllocateAndSetupSMRDataStructures(List<MB_DynamicGameObject> dgosToAdd, List<MB_DynamicGameObject> dgosInCombinedMesh, int newVertSize)
            {
                if (combiner.settings.renderType == MB_RenderType.skinnedMeshRenderer)
                {
                    Debug.Assert(_initialized && !_disposed);
                    _CollectSkinningDataForDGOsInCombinedMesh(dgosToAdd, dgosInCombinedMesh, combiner._meshChannelsCache);
                    _BuildMasterBonesArray(dgosToAdd, dgosInCombinedMesh);
                    _AllocateNewArraysForCombinedMesh(newVertSize);
                }
            }

            public void UpdateGameObjects_ReadBoneWeightInfoFromCombinedMesh()
            {
                if (combiner.settings.renderType == MB_RenderType.skinnedMeshRenderer)
                {
                    Debug.Assert(_initialized && !_disposed);

                    // These are readonly. They are owned by the Mesh. We should NOT dispose these
                    NativeArray<BoneWeight1> bws = combiner._mesh.GetAllBoneWeights();
                    NativeArray<byte> bpvs = combiner._mesh.GetBonesPerVertex();

                    boneWeight1s_nvarr = new NativeArray<BoneWeight1>(bws, Allocator.Persistent);
                    bonesPerVertex_nvarr = new NativeArray<byte>(bpvs, Allocator.Persistent);

                    {
                        // We need to know where the block of boneweights starts for each dgo
                        dgo2firstIdxInBoneWeightsArray.Clear();
                        int bwIdx = 0;
                        int vertThisMeshIdx = 0;
                        int dgoIdx = 0;
                        MB_DynamicGameObject dgo = combiner.mbDynamicObjectsInCombinedMesh[dgoIdx];
                        dgo2firstIdxInBoneWeightsArray[dgo] = 0;
                        for (int vertIdx = 0; vertIdx < combiner._mesh.vertexCount; vertIdx++)
                        {
                            if (vertThisMeshIdx >= dgo.numVerts)
                            {
                                dgoIdx++;
                                dgo = combiner.mbDynamicObjectsInCombinedMesh[dgoIdx];
                                dgo2firstIdxInBoneWeightsArray[dgo] = bwIdx;
                                if (dgoIdx == combiner.mbDynamicObjectsInCombinedMesh.Count - 1) break;
                                vertThisMeshIdx = 0;
                            }

                            bwIdx += bonesPerVertex_nvarr[vertIdx];
                            Debug.Assert(bwIdx < boneWeight1s_nvarr.Length);
                            vertThisMeshIdx++;
                        }
                    }
                }
            }

            public void CopyBoneWeightsFromMeshForDGOsInCombined(MB_DynamicGameObject dgo, int targVidx)
            {
                AddBonesToNewBonesArrayAndAdjustBWIndexes1(dgo, targVidx);
            }

            public void AddBonesToNewBonesArrayAndAdjustBWIndexes1(
                                                            MB_DynamicGameObject dgo,
                                                            int firstVertexIdxForThisDGO // in the combined mesh
                                                            )
            {
                Debug.Assert(_initialized);
                int[] srcIndex2combinedIndexMap = dgo._tmpSMR_srcMeshBoneIdx2masterListBoneIdx;
                Debug.Assert(srcIndex2combinedIndexMap != null);

                //remap the bone weights for this dgo
                //build a list of usedBones, can't trust dgoBones because it contains all bones in the rig
                int srcBoneWeightIdx = 0;

                // Debug.Log( dgo.gameObject + "    targBoneWeightIdx: " + targBoneWeightIdx + " numBoneWeights " + dgo.numBoneWeights);
                // string s = "";
                for (int vertIdx = 0; vertIdx < dgo.numVerts; vertIdx++)
                {
                    byte numBonesThisVertex = dgo._tmpSMR_CachedBoneWeightData.bonesPerVertex[vertIdx];
                    bonesPerVertex_nvarr[firstVertexIdxForThisDGO + vertIdx] = numBonesThisVertex;
                    // s += "  numBones: " + numBones + "\n";
                    for (int bwThisVertexIdx = 0; bwThisVertexIdx < numBonesThisVertex; bwThisVertexIdx++)
                    {
                        BoneWeight1 bw = dgo._tmpSMR_CachedBoneWeightData.boneWeights[srcBoneWeightIdx];
                        bw.boneIndex = srcIndex2combinedIndexMap[bw.boneIndex];
                        boneWeight1s_nvarr[targBoneWeightIdx + srcBoneWeightIdx] = bw;
                        // s += "   setting boneWeights: " + (targBoneWeightIdx + srcBoneWeightIdx) + "  of: " + combiner.boneWeight1s_nvarr.Length + "  to: boneIdx:" + bw.boneIndex + "  weight:" + bw.weight + "\n";
                        srcBoneWeightIdx++;
                    }
                }

                // Debug.Log(dgo.gameObject + " copying and adjusting indexes  " + dgo._tmpSMR_CachedBoneWeightData.bonesPerVertex.Length + "\n" + s);

                {
                    // repurposing the _tmpIndexesOfSourceBonesUsed since
                    // we don't need it anymore and this saves a memory allocation . remap the indexes that point to source bones to combined bones.
                    for (int j = 0; j < dgo._tmpSMR_srcMeshBoneIdx2masterListBoneIdx.Length; j++)
                    {
                        int masterListOfBonesIdx = dgo._tmpSMR_srcMeshBoneIdx2masterListBoneIdx[j];
                        dgo._tmpSMR_srcMeshBoneIdx2masterListBoneIdx[j] = masterListOfBonesIdx;
                    }

                    dgo.indexesOfBonesUsed = dgo._tmpSMR_srcMeshBoneIdx2masterListBoneIdx;
                }

                targBoneWeightIdx += dgo.numBoneWeights;

                dgo._tmpSMR_srcMeshBoneIdx2masterListBoneIdx = null;
                dgo._tmpSMR_CachedBones = null;
                dgo._tmpSMR_CachedBindposes = null;
                dgo._tmpSMR_CachedBoneWeights = null;
                dgo._tmpSMR_CachedBoneAndBindPose = null;
                // Don't dispose _tmpSMR_CachedBoneWeightData here because it is refs to shared NativeArrays that may be used by other renderers using the same mesh.
            }


            public void CopyBonesWeAreKeepingToNewBonesArrayAndAdjustBWIndexes(int totalDeleteVerts)
            {
                // Nothing to do. This interface function was needed by an older algorithm but not needed by this one.
            }

            public void InsertNewBonesIntoBonesArray()
            {
                if (combiner.settings.renderType == MB_RenderType.skinnedMeshRenderer)
                {
                    Debug.Assert(_initialized && !_disposed, _initialized + "  " + _disposed);
                    combiner.bindPoses = nBindPoses;
                    combiner.bones = nbones;
                } else
                {
                    if (combiner.bindPoses == null || combiner.bindPoses.Length > 0) combiner.bindPoses = new Matrix4x4[0];
                    if (combiner.bones == null || combiner.bones.Length > 0) combiner.bones = new Transform[0];
                }
            }

            public void CopyVertsNormsTansToBuffers(MB_DynamicGameObject dgo, MB_IMeshBakerSettings settings, int vertsIdx, Vector3[] nnorms, Vector4[] ntangs, Vector3[] nverts, Vector3[] normals, Vector4[] tangents, Vector3[] verts)
            {
                bool isMeshRenderer = dgo._renderer is MeshRenderer;
                if (settings.smrNoExtraBonesWhenCombiningMeshRenderers &&
                    isMeshRenderer &&
                    dgo._tmpSMR_CachedBones[0] != dgo.gameObject.transform // bone may not have a parent ancestor that is a bone
                    )
                {
                    // transform all the verticies, norms and tangents into the parent bone's local space (adjusted by the parent bone's bind pose).
                    // there should be only one bone and bind pose for a mesh renderer dgo. 
                    // The bone and bind pose should be the parent-bone's NOT the MeshRenderers.
                    Matrix4x4 l2parentMat = dgo._tmpSMR_CachedBindposes[0].inverse * dgo._tmpSMR_CachedBones[0].worldToLocalMatrix * dgo.gameObject.transform.localToWorldMatrix;

                    // Similar to local2world but with translation removed and we are using the inverse transpose.
                    // We use this for normals and tangents because it handles scaling correctly.
                    Matrix4x4 l2parentRotScale = l2parentMat;
                    l2parentRotScale[0, 3] = l2parentRotScale[1, 3] = l2parentRotScale[2, 3] = 0f;
                    l2parentRotScale = l2parentRotScale.inverse.transpose;

                    //can't modify the arrays we get from the cache because they will be modified multiple times if the same mesh is being added multiple times.
                    for (int j = 0; j < dgo._mesh.vertexCount; j++)
                    {
                        int vIdx = vertsIdx + j;
                        if (verts != null)
                        {
                            verts[vertsIdx + j] = l2parentMat.MultiplyPoint3x4(nverts[j]);
                        }

                        if (settings.doNorm && nnorms != null)
                        {
                            normals[vIdx] = l2parentRotScale.MultiplyPoint3x4(nnorms[j]).normalized;
                        }

                        if (settings.doTan && ntangs != null)
                        {
                            float w = ntangs[j].w; //need to preserve the w value
                            tangents[vIdx] = l2parentRotScale.MultiplyPoint3x4(((Vector3)ntangs[j])).normalized;
                            tangents[vIdx].w = w;
                        }
                    }
                }
                else
                {
                    if (settings.doNorm && nnorms != null) nnorms.CopyTo(normals, vertsIdx);
                    if (settings.doTan && ntangs != null) ntangs.CopyTo(tangents, vertsIdx);
                    if (verts != null) nverts.CopyTo(verts, vertsIdx);
                }
            }

            public void ApplySMRdataToMesh(MB3_MeshCombinerSingle combiner, Mesh mesh)
            {
                Debug.Assert(_initialized && !_disposed);
                Debug.Assert(combiner._boneProcessor == this);
                Debug.Assert(combiner.bakeStatus == MeshCombiningStatus.readyForApply);
                Debug.Assert(bonesPerVertex_nvarr.IsCreated, "Boneweight data was disposed.");
                Debug.Assert(boneWeight1s_nvarr.IsCreated, "Boneweight data was disposed.");
                
                mesh.bindposes = combiner.bindPoses;
                mesh.SetBoneWeights(bonesPerVertex_nvarr, boneWeight1s_nvarr);

                bonesPerVertex_nvarr.Dispose();
                boneWeight1s_nvarr.Dispose();
            }

            public void UpdateGameObjects_UpdateBWIndexes(MB_DynamicGameObject dgo)
            {
                //only does BoneWeights. Used to do Bones and BindPoses but it doesn't make sence.
                //if updating Bones and Bindposes should remove and re-add
                Debug.Assert(dgo._initialized);

                {
                    Debug.Assert(dgo._initialized);
                    NativeArray<BoneWeight1> bws = dgo._tmpSMR_CachedBoneWeightData.boneWeights;
                    

                    bool switchedBonesDetected = false;
                    int bwIdx = dgo2firstIdxInBoneWeightsArray[dgo];
                    for (int i = 0; i < bws.Length; i++)
                    {
                        /*
                        if (rendererBones[bws[i].boneIndex0] != bonesBuffer[boneWeights[bwIdx].boneIndex0])
                        {
                            switchedBonesDetected = true;
                            break;
                        }
                        boneWeights[bwIdx].weight0 = bws[i].weight0;
                        boneWeights[bwIdx].weight1 = bws[i].weight1;
                        boneWeights[bwIdx].weight2 = bws[i].weight2;
                        boneWeights[bwIdx].weight3 = bws[i].weight3;
                        */
                        BoneWeight1 bw = bws[i];
                        bw.boneIndex = dgo.indexesOfBonesUsed[bw.boneIndex];
                        boneWeight1s_nvarr[bwIdx] = bw;
                        bwIdx++;
                    }

                    if (switchedBonesDetected)
                    {
                        Debug.LogError("Detected that some of the boneweights reference different bones than when initial added. Boneweights must reference the same bones " + dgo.name);
                    }
                }
                
            }

            protected void Dispose(bool disposing)
            {
                if (_disposed) return;
                if (disposing)
                {
                    if (boneWeight1s_nvarr.IsCreated) boneWeight1s_nvarr.Dispose();
                    if (bonesPerVertex_nvarr.IsCreated) bonesPerVertex_nvarr.Dispose();
                }

                _disposed = true;
            }

            public void Dispose()
            {
                Dispose(true);
            }

            public void DisposeOfTemporarySMRData()
            {
                if (bonesToAddAndInCombined != null) bonesToAddAndInCombined.Clear();
                if (masterList != null) masterList.Clear();
                if (dgo2firstIdxInBoneWeightsArray != null) dgo2firstIdxInBoneWeightsArray.Clear();
                nBindPoses = null;
                nbones = null;

                for (int i = 0; i < combiner.mbDynamicObjectsInCombinedMesh.Count; i++)
                {
                    MB_DynamicGameObject dgo = combiner.mbDynamicObjectsInCombinedMesh[i];
                    dgo._tmpSMR_srcMeshBoneIdx2masterListBoneIdx = null;
                    dgo._tmpSMR_CachedBindposes = null;
                    dgo._tmpSMR_CachedBoneAndBindPose = null;
                    dgo._tmpSMR_CachedBones = null;
                    dgo._tmpSMR_CachedBoneWeightData.Dispose();
                    dgo._tmpSMR_CachedBoneWeights = null;
                }
            }

            internal void _AllocateNewArraysForCombinedMesh(int newVertSize)
            {
                if (boneWeight1s_nvarr.IsCreated)
                {
                    boneWeight1s_nvarr.Dispose();
                }

                if (bonesPerVertex_nvarr.IsCreated)
                {
                    bonesPerVertex_nvarr.Dispose();
                }

                boneWeight1s_nvarr = new NativeArray<BoneWeight1>(boneWeightSize, Allocator.Persistent);
                bonesPerVertex_nvarr = new NativeArray<byte>(newVertSize, Allocator.Persistent);

                nBindPoses = new Matrix4x4[masterList.Count];
                nbones = new Transform[masterList.Count];
                for (int i = 0; i < masterList.Count; i++)
                {
                    nBindPoses[i] = masterList[i].bindPose;
                    nbones[i] = masterList[i].bone;
                }

                targBoneWeightIdx = 0;
            }

            private bool _CollectBonesToAddForDGO_Pass2(MB_DynamicGameObject dgo, bool noExtraBonesForMeshRenderers)
            {
                bool success = true;
                Debug.Assert(_initialized, "Need to setup first.");
                // We could be working with adding and deleting smr body parts from the same rig. Different smrs will share 
                // the same bones.
                //cache the bone data that we will be adding.
                Matrix4x4[] dgoBindPoses = dgo._tmpSMR_CachedBindposes;
                Transform[] dgoBones = dgo._tmpSMR_CachedBones;

                if (noExtraBonesForMeshRenderers)
                {
                    Debug.Assert(bonesToAddAndInCombined.Count > 0, "Must have initialized bonesToAddAndInCombined");
                    if (dgo._renderer is MeshRenderer)
                    {
                        // We are visiting a single dgo which is a MeshRenderer.
                        // It may be the child decendant of a bone in another skinned mesh that is being baked or is already in the combined mesh. We need to find that bone if it exists.
                        // We need to check our parent ancestors and search the bone lists of the other dgos being added or previously baked looking for bones that may have been added 
                        Debug.Assert(dgoBones.Length == 1 && dgoBindPoses.Length == 1);
                        //     find and cache the parent bone for this MeshRenderer (it may not be the transform.parent)
                        bool foundBoneParent = false;
                        BoneAndBindpose boneParent = new BoneAndBindpose();
                        {
                            Transform parentTrans = dgo.gameObject.transform.parent;
                            while (parentTrans != null)
                            {
                                // Look for parent peviously baked in the combined mesh.

                                foreach (BoneAndBindpose bbp in bonesToAddAndInCombined)
                                {
                                    if (bbp.bone == parentTrans)
                                    {
                                        boneParent = bbp;
                                        foundBoneParent = true;
                                        break;
                                    }
                                }

                                if (foundBoneParent)
                                {
                                    break;
                                }
                                else
                                {
                                    parentTrans = parentTrans.parent;
                                }
                            }
                        }

                        if (foundBoneParent)
                        {
                            dgoBones[0] = boneParent.bone;
                            dgoBindPoses[0] = boneParent.bindPose;
                        }
                    }
                }

                // For each bone see if it exists in the bones array (with the same bindpose.).
                // We might be baking several skinned meshes on the same rig. We don't want duplicate bones in the bones array.
                for (int i = 0; i < dgoBones.Length; i++)
                {
                    if (dgo._tmpSMR_CachedBoneWeightData.UsedBoneIdxsInSrcMesh[i])
                    {
                        BoneAndBindpose bb = new BoneAndBindpose(dgoBones[i], dgoBindPoses[i]);
                        dgo._tmpSMR_CachedBoneAndBindPose[i] = bb;
                    }
                }

                return success;
            }


            private int _BuildMasterBonesArray(List<MB_DynamicGameObject> dgosToAdd, List<MB_DynamicGameObject> dgosInCombinedMesh)
            {
                Debug.Assert(_initialized);
                Debug.Assert(combiner.settings.renderType == MB_RenderType.skinnedMeshRenderer);
                ///    Step 3) Merge the bones into a master list of distinct bone:bindposes
                ///                 BuildMasterBonesArray()
                ///                 Remove bone:bindposes from master set that have nothing referencing them.
                ///                 Convert remaining set of bone:bindposes to a master array of distinct bone:bindposes
                boneWeightSize = 0;
                Dictionary<BoneAndBindpose, int> boneAndBindPose2index = new Dictionary<BoneAndBindpose, int>();
                masterList.Clear();

                {
                    // Meshes we are keeping that are already in the combined mesh.
                    // Add the bones in the same order.
                    for (int dgoIdx = 0; dgoIdx < dgosInCombinedMesh.Count; dgoIdx++)
                    {
                        if (!dgosInCombinedMesh[dgoIdx]._beingDeleted)
                        {
                            MB_DynamicGameObject dgo = dgosInCombinedMesh[dgoIdx];
                            Debug.Assert(dgo._tmpSMR_CachedBoneWeightData.initialized);
                            Debug.Assert(dgo.numBoneWeights > 0);
                            // Debug.Log("AAA   Existing: " + dgo.gameObject + "  " + boneWeightSize + "  " + dgo.numBoneWeights + "  " + (boneWeightSize + dgo.numBoneWeights));
                            boneWeightSize += dgo.numBoneWeights;

                            int numBonesInDgo = dgo._tmpSMR_CachedBoneAndBindPose.Length;
                            int[] srcMeshBoneIdx2masterListBoneIdx = new int[numBonesInDgo];
                            Debug.Assert(srcMeshBoneIdx2masterListBoneIdx.Length > 0);
                            for (int srcBoneIdx = 0; srcBoneIdx < numBonesInDgo; srcBoneIdx++)
                            {
                                if (dgo._tmpSMR_CachedBoneWeightData.UsedBoneIdxsInSrcMesh[srcBoneIdx])  // some of these bones may not be actually used
                                {
                                    BoneAndBindpose bbp = dgo._tmpSMR_CachedBoneAndBindPose[srcBoneIdx];
                                    int idxInMasterList;
                                    if (!boneAndBindPose2index.TryGetValue(bbp, out idxInMasterList))
                                    {
                                        boneAndBindPose2index.Add(bbp, masterList.Count);
                                        idxInMasterList = masterList.Count;
                                        masterList.Add(bbp);
                                    }

                                    srcMeshBoneIdx2masterListBoneIdx[srcBoneIdx] = idxInMasterList;
                                }
                            }

                            dgo._tmpSMR_srcMeshBoneIdx2masterListBoneIdx = srcMeshBoneIdx2masterListBoneIdx;
                        }
                    }

                    for (int dgoIdx = 0; dgoIdx < dgosToAdd.Count; dgoIdx++)
                    {
                        MB_DynamicGameObject dgo = dgosToAdd[dgoIdx];
                        Debug.Assert(dgo._tmpSMR_CachedBoneWeightData.initialized);
                        Debug.Assert(dgo.numBoneWeights > 0);
                        // Debug.Log("AAA   ADDING: " + dgo.gameObject + "  " + boneWeightSize + "  " + dgo.numBoneWeights + "  " + (boneWeightSize + dgo.numBoneWeights));
                        boneWeightSize += dgo.numBoneWeights;

                        int numBonesInDgo = dgo._tmpSMR_CachedBoneAndBindPose.Length;
                        int[] srcMeshBoneIdx2masterListBoneIdx = new int[numBonesInDgo];
                        Debug.Assert(srcMeshBoneIdx2masterListBoneIdx.Length > 0);
                        for (int srcBoneIdx = 0; srcBoneIdx < numBonesInDgo; srcBoneIdx++)
                        {
                            if (dgo._tmpSMR_CachedBoneWeightData.UsedBoneIdxsInSrcMesh[srcBoneIdx])
                            {
                                BoneAndBindpose bbp = dgo._tmpSMR_CachedBoneAndBindPose[srcBoneIdx];
                                int idxInMasterList;
                                if (!boneAndBindPose2index.TryGetValue(bbp, out idxInMasterList))
                                {
                                    boneAndBindPose2index.Add(bbp, masterList.Count);
                                    idxInMasterList = masterList.Count;
                                    masterList.Add(bbp);
                                }

                                srcMeshBoneIdx2masterListBoneIdx[srcBoneIdx] = idxInMasterList;
                            }
                        }

                        dgo._tmpSMR_srcMeshBoneIdx2masterListBoneIdx = srcMeshBoneIdx2masterListBoneIdx;
                    }
                }

                return masterList.Count;
            }

            internal void _CollectSkinningDataForDGOsInCombinedMesh(List<MB_DynamicGameObject> dgosAdding, List<MB_DynamicGameObject> dgosInCombinedMesh, MeshChannelsCache meshChannelsCache)
            {
                bonesToAddAndInCombined = new HashSet<BoneAndBindpose>();

                {
                    // Second pass -----------
                    for (int i = 0; i < dgosAdding.Count; i++)
                    {
                        MB_DynamicGameObject dgo = dgosAdding[i];
                        _CollectBonesToAddForDGO_Pass2(dgo, combiner.settings.smrNoExtraBonesWhenCombiningMeshRenderers);
                    }

                    for (int i = 0; i < dgosInCombinedMesh.Count; i++)
                    {
                        MB_DynamicGameObject dgo = dgosInCombinedMesh[i];
                        if (!dgo._beingDeleted)
                        {
                            _CollectBonesToAddForDGO_Pass2(dgo, combiner.settings.smrNoExtraBonesWhenCombiningMeshRenderers);
                        }
                    }
                }
            }

            public bool DB_CheckIntegrity()
            {
                return true;
            }
        }
#endif
    }
}


    

