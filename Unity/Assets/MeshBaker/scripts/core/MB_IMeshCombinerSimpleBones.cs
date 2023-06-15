using System;
using System.Collections.Generic;
using UnityEngine;

namespace DigitalOpus.MB.Core
{
    public interface MB_IMeshCombinerSimpleBones : IDisposable
    {
        bool GetCachedSMRMeshData(MB3_MeshCombinerSingle.MB_DynamicGameObject dgo);
        void AddBonesToNewBonesArrayAndAdjustBWIndexes1(MB3_MeshCombinerSingle.MB_DynamicGameObject dgo, int vertsIdx);
        void AllocateAndSetupSMRDataStructures(List<MB3_MeshCombinerSingle.MB_DynamicGameObject> toAddDGOs, List<MB3_MeshCombinerSingle.MB_DynamicGameObject> mbDynamicObjectsInCombinedMesh, int newVertSize);
        void BuildBoneIdx2DGOMapIfNecessary(int[] _goToDelete);
        void CopyBonesWeAreKeepingToNewBonesArrayAndAdjustBWIndexes(int totalDeleteVerts);
        void InsertNewBonesIntoBonesArray();
        int GetNewBonesSize();
        void RemoveBonesForDgosWeAreDeleting(MB3_MeshCombinerSingle.MB_DynamicGameObject dgo);
        void CopyBoneWeightsFromMeshForDGOsInCombined(MB3_MeshCombinerSingle.MB_DynamicGameObject dgo, int targVidx);
        void CopyVertsNormsTansToBuffers(MB3_MeshCombinerSingle.MB_DynamicGameObject dgo, MB_IMeshBakerSettings settings, int vertsIdx, Vector3[] nnorms, Vector4[] ntangs, Vector3[] nverts, Vector3[] normals, Vector4[] tangents, Vector3[] verts);
        void DisposeOfTemporarySMRData();
        void ApplySMRdataToMesh(MB3_MeshCombinerSingle combiner, Mesh mesh);

        void UpdateGameObjects_ReadBoneWeightInfoFromCombinedMesh();

        void UpdateGameObjects_UpdateBWIndexes(MB3_MeshCombinerSingle.MB_DynamicGameObject dgo);

        bool DB_CheckIntegrity();
    }
}