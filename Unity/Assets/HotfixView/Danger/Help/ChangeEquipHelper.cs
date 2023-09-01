using System.Collections.Generic;
using UnityEngine;

namespace ET
{

    public class ChangeEquipHelperAwakeSystem : AwakeSystem<ChangeEquipHelper>
    {
        public override void Awake(ChangeEquipHelper self)
        {
            self.gameObjects.Clear();
            self.skinnedMeshRenderers.Clear();
            self.FashionBase.Clear();
        }
    }

    public class ChangeEquipHelperAwakeDestroy : DestroySystem<ChangeEquipHelper>
    {
        public override void Destroy(ChangeEquipHelper self)
        {
            if (self.newDiffuseTexture != null)
            {
                GameObject.DestroyImmediate(self.newDiffuseTexture);        
            }
            self.newDiffuseTexture = null;  
        }
    }

    public static class ChangeEquipHelperSystem
    {

        public static int get2Pow(this ChangeEquipHelper self, int into)
        {
            int outo = 1;
            for (int i = 0; i < 10; i++)
            {
                outo *= 2;
                if (outo > into)
                {
                    break;
                }
            }

            return outo;
        }

        public static void OnLoadGameObject(this ChangeEquipHelper self, GameObject go, long formId)
        {
            if (self.IsDisposed)
            {
                //删除加载出来的子部件
                foreach (GameObject goTemp in self.gameObjects)
                {
                    if (goTemp)
                    {
                        GameObject.Destroy(goTemp);
                    }
                }
                return;
            }

            self.gameObjects.Add(go);
            go.transform.parent = self.trparent;
            go.transform.localRotation = Quaternion.identity;
            go.transform.localPosition = Vector3.zero;
            go.transform.localScale = Vector3.one;
            self.skinnedMeshRenderers.Add(go.GetComponentInChildren<SkinnedMeshRenderer>());
            if (self.gameObjects.Count >= self.FashionBase.Count)
            {
                self.OnAllLoadComplete();
            }
        }

        public static void Combine(this ChangeEquipHelper self, GameObject avatar, SkinnedMeshRenderer[] skinneds, bool mergeSubMeshes)
        {
            //1.取出所有骨骼
            Transform[] allbone = avatar.GetComponentsInChildren<Transform>();
            Dictionary<string, Transform> dicbone = new Dictionary<string, Transform>();
            for (int i = 0; i < allbone.Length; i++)
            {
                dicbone.Add(allbone[i].name, allbone[i]);
            }
            //2.根据是否合并子网格判断是否合并材质
            List<Vector2[]> olduvlist = new List<Vector2[]>();
            Material material = new Material(Shader.Find("Custom/Face"));
            List<Material> materials = new List<Material>();
            if (mergeSubMeshes)
            {
                List<Texture2D> texture2s = new List<Texture2D>();
                for (int i = 0; i < skinneds.Length; i++)
                {
                    texture2s.Add(skinneds[i].sharedMaterial.GetTexture("_BackTex") as Texture2D);
                }
                Texture2D texture = new Texture2D(1024, 1024);
                Rect[] rects = texture.PackTextures(texture2s.ToArray(), 0);
                //修改模型uv坐标
                for (int i = 0; i < skinneds.Length; i++)
                {
                    Vector2[] olduv = skinneds[i].sharedMesh.uv;
                    olduvlist.Add(olduv);
                    Vector2[] newuv = new Vector2[olduv.Length];
                    for (int j = 0; j < olduv.Length; j++)
                    {
                        float uvx = rects[i].x + rects[i].width * olduv[j].x;
                        float uvy = rects[i].y + rects[i].height * olduv[j].y;
                        newuv[j] = new Vector2(uvx, uvy);
                    }
                    skinneds[i].sharedMesh.uv = newuv;
                }
                Texture2D face = skinneds[0].sharedMaterial.GetTexture("_MainTex") as Texture2D;
                material.SetTexture("_BackTex", texture);
                material.SetTexture("_MainTex", face);
                material.SetFloat("_PosX", texture.width / face.width);
                material.SetFloat("_PosY", texture.height / face.height);
            }
            else
            {
                for (int i = 0; i < skinneds.Length; i++)
                {
                    materials.Add(skinneds[i].sharedMaterial);
                }
            }
            //3.取出网格合并
            List<CombineInstance> combines = new List<CombineInstance>();
            for (int i = 0; i < skinneds.Length; i++)
            {
                CombineInstance combine = new CombineInstance();
                combine.mesh = skinneds[i].sharedMesh;
                combine.transform = skinneds[i].transform.localToWorldMatrix;
                combines.Add(combine);
            }
            Mesh mesh = new Mesh();
            mesh.CombineMeshes(combines.ToArray(), mergeSubMeshes, false);
            //4.找到需要使用的骨骼
            List<Transform> bones = new List<Transform>();
            for (int i = 0; i < skinneds.Length; i++)
            {
                for (int j = 0; j < skinneds[i].bones.Length; j++)
                {
                    if (dicbone.ContainsKey(skinneds[i].bones[j].name))
                    {
                        bones.Add(dicbone[skinneds[i].bones[j].name]);
                    }
                }
            }
            //5.赋值
            avatar.GetComponent<SkinnedMeshRenderer>().sharedMesh = mesh;
            avatar.GetComponent<SkinnedMeshRenderer>().bones = bones.ToArray();
            if (mergeSubMeshes)
            {
                avatar.GetComponent<SkinnedMeshRenderer>().material = material;
            }
            else
            {
                avatar.GetComponent<SkinnedMeshRenderer>().materials = materials.ToArray();
            }
        }

        public static void OnAllLoadComplete(this ChangeEquipHelper self)
        {
            List<Transform> oldBones = new List<Transform>();
            oldBones.AddRange(self.trparent.GetComponentsInChildren<Transform>());
            SkinnedMeshRenderer newSkinMR = self.trparent.GetComponentInChildren<SkinnedMeshRenderer>();

            //利用这个来整合所有的submesh
            List<CombineInstance> combineInstances = new List<CombineInstance>();
            //记录所有的uv点,uvList中每一个元素代表子部件的所有uv点集合
            List<Vector2[]> uvList = new List<Vector2[]>();
            //整合后的所有uv点的数量
            int newUVCount = 0;
            //新的骨骼index列表,用来存储对应于蒙皮组合顺序的,所有骨骼的index信息
            List<Transform> boneList = new List<Transform>();
            //所有子部件中的漫反射贴图,目前工程资源里只有一个漫反射贴图,如果还有法线这类贴图,也要缝合成一张新贴图
            List<Texture2D> diffuseTextureList = new List<Texture2D>();
            //新漫反射图片的分辨率
            int diffuseTextureWidth = 0;
            int diffuseTextureHeight = 0;
            foreach (var skinMR in self.skinnedMeshRenderers)
            {
                //BoneWeight[] boneWeightsArr = skinMR.sharedMesh.boneWeights;
                //for (int i = 0; i < boneWeightsArr.Length; i++)
                //{
                //    Log.ILog.Debug(boneWeightsArr[i].ToString());
                //}
                //找到每一个submesh
                for (int sub = 0; sub < skinMR.sharedMesh.subMeshCount; sub++)
                {
                    CombineInstance ci = new CombineInstance();
                    ci.mesh = skinMR.sharedMesh;
                    ci.subMeshIndex = sub;
                    combineInstances.Add(ci);
                }
                uvList.Add(skinMR.sharedMesh.uv);
                newUVCount += skinMR.sharedMesh.uv.Length;
                //从子蒙皮中找到其绑定的骨骼的index数组,然后加入到骨骼列表中
                //这里的顺序对应了蒙皮的顺序,实际写应该用for()才合理,不过这里foreach顺序是一样的
                foreach (Transform bone in skinMR.bones)
                {
                    foreach (Transform item in oldBones)
                    {
                        if (item.name != bone.name) continue;
                        boneList.Add(item);
                        break;
                    }
                }
                if (skinMR.sharedMaterial.mainTexture != null)
                {
                    diffuseTextureList.Add(skinMR.sharedMaterial.mainTexture as Texture2D);
                    diffuseTextureWidth += skinMR.sharedMaterial.mainTexture.width;
                    diffuseTextureHeight += skinMR.sharedMaterial.mainTexture.height;
                }
            }

            newSkinMR.sharedMesh = new Mesh();
            //整合mesh
            newSkinMR.sharedMesh.CombineMeshes(combineInstances.ToArray(), true, false);
            //刷新骨骼索引数据
            newSkinMR.bones = boneList.ToArray();
           
            Texture2D[] texture2Ds = diffuseTextureList.ToArray();
            Vector2[] newUVs = new Vector2[newUVCount];

            //构造新的漫反射贴图
            Texture2D newDiffuseTexture = new Texture2D(self.get2Pow(diffuseTextureWidth), self.get2Pow(diffuseTextureHeight));
            Rect[] packingResult = newDiffuseTexture.PackTextures(texture2Ds, 0);
            // 因为将贴图都整合到了一张图片上，所以需要重新计算UV
            int j = 0;
            for (int i = 0; i < uvList.Count; i++)
            {
                foreach (Vector2 uv in uvList[i])
                {
                    newUVs[j].x = Mathf.Lerp(packingResult[i].xMin, packingResult[i].xMax, uv.x);
                    newUVs[j].y = Mathf.Lerp(packingResult[i].yMin, packingResult[i].yMax, uv.y);
                    j++;
                }
            }

            newSkinMR.sharedMesh.uv = newUVs;
            // 设置漫反射贴图和UV
            newSkinMR.material.mainTexture = newDiffuseTexture;
            self.newDiffuseTexture = newDiffuseTexture;
            //GameObjectPoolComponent.Instance.AddPlayerGameObject(self.Occ, self.trparent.gameObject);
            self.RecoverGameObject();
        }

        public static void LoadPrefab_2(this ChangeEquipHelper self,  string asset)
        {
            GameObjectPoolComponent.Instance.AddLoadQueue(asset, self.InstanceId, self.OnLoadGameObject);
        }

        public static void RecoverGameObject(this ChangeEquipHelper self)
        {
            Dictionary<string, KeyValuePair<int,int>> fashionmap = new Dictionary<string, KeyValuePair<int, int>>();  
            foreach (var item in self.FashionBase)
            {
                string name = self.GetPartsPath_2(self.Occ, item.Key, item.Value);
                fashionmap.Add(name, item);
            }

            for (int i = self.gameObjects.Count - 1; i >= 0; i--)
            {
                string assets = self.gameObjects[i].name;
                assets = assets.Substring(0, assets.Length - 7);

                fashionmap.TryGetValue(assets, out var keyValue);
                if (keyValue.Key != 0)
                {
                    GameObjectPoolComponent.Instance.RecoverGameObject(self.GetPartsPath(self.Occ, keyValue.Key, keyValue.Value), self.gameObjects[i]);
                }
                else
                {
                    Log.Debug($"self.gameObjects[i].name == {self.gameObjects[i].name} : null");
                    GameObject.Destroy(self.gameObjects[i]);
                }

            }

            self.gameObjects.Clear();
        }

        public static string GetPartsPath(this ChangeEquipHelper self, int occ, int subType, int fashonid)
        {
            string assets = string.Empty;
            if (fashonid == 0)
            {
                assets = UICommonHelper.FashionBaseTemplate[subType];
                return ABPathHelper.GetUnitPath($"Parts/{occ}/{assets}");
            }
            else
            {
                assets = FashionConfigCategory.Instance.Get(fashonid).Model;
                return ABPathHelper.GetUnitPath($"Parts/Fashion/{assets}");
            }
        }

        public static string GetPartsPath_2(this ChangeEquipHelper self, int occ, int subType, int fashonid)
        {
            string assets = string.Empty;
            if (fashonid == 0)
            {
                assets = UICommonHelper.FashionBaseTemplate[subType];
            }
            else
            {
                assets = FashionConfigCategory.Instance.Get(fashonid).Model;
            }
            return assets;
        }

        public static void LoadEquipment(this ChangeEquipHelper self, GameObject target, List<int> fashionids, int occ)
        {
            OccupationConfig occupationConfig = OccupationConfigCategory.Instance.Get(occ);
            if (occupationConfig.ChangeEquip == 0)
            {
                return;
            }

            self.Occ = occ;
            self.gameObjects.Clear();
            self.skinnedMeshRenderers.Clear();
            self.trparent = target.transform;
            self.FashionBase.Clear();


            for (int i = 0; i < fashionids.Count; i++)
            {
                FashionConfig fashionConfig = FashionConfigCategory.Instance.Get(fashionids[i]);
                self.FashionBase.Add(fashionConfig.SubType, fashionids[i]);
            }

           
            for (int i = 0; i < occupationConfig.FashionBase.Length; i++)
            {
                if (!self.FashionBase.ContainsKey(occupationConfig.FashionBase[i]))
                {
                    self.FashionBase.Add(occupationConfig.FashionBase[i], 0);
                }
            }

            foreach (var item in self.FashionBase)
            {
                self.LoadPrefab_2(self.GetPartsPath(occ, item.Key, item.Value));
            }
        }
    }


    public  class ChangeEquipHelper : Entity, IAwake, IDestroy
    {
        //找到满足新贴图大小最合适的值,是2的倍数,这里限制了贴图分辨率最大为2的10次方,即1024*1024
        public int Occ;

        public Texture2D newDiffuseTexture;

        public Transform trparent;
        public List<GameObject> gameObjects = new List<GameObject>();

        public Dictionary<int, int> FashionBase = new Dictionary<int, int>();

        public List<SkinnedMeshRenderer> skinnedMeshRenderers = new List<SkinnedMeshRenderer>();
    }
}
