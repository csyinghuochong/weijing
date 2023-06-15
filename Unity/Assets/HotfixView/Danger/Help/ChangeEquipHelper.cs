using libx;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using UnityEngine;

namespace ET
{

    public class ChangeEquipHelperAwakeSystem : AwakeSystem<ChangeEquipHelper>
    {
        public override void Awake(ChangeEquipHelper self)
        {
            self.gameObjects.Clear();
            self.skinnedMeshRenderers.Clear();
        }
    }

    public class ChangeEquipHelperAwakeDestroy : DestroySystem<ChangeEquipHelper>
    {
        public override void Destroy(ChangeEquipHelper self)
        {
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

        public static void LoadPrefab_1(this ChangeEquipHelper self, List<GameObject> gameObjects, string asset, Transform parent, List<SkinnedMeshRenderer> skinnedMeshRenderers)
        {
            var path = ABPathHelper.GetUnitPath(asset);
            GameObject prefab =  ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            GameObject go = UnityEngine.Object.Instantiate(prefab, GlobalComponent.Instance.Unit, true);

            go.transform.parent = parent;
            go.transform.localRotation = Quaternion.identity;
            go.transform.localPosition = Vector3.zero;
            go.transform.localScale = Vector3.one;
            skinnedMeshRenderers.Add(go.GetComponentInChildren<SkinnedMeshRenderer>());
            gameObjects.Add(go);
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
            if (self.gameObjects.Count >= UICommonHelper.ChangeEquip[self.Occ].Count)
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
            self.trparent.Find("ChangeEquip").gameObject.SetActive(true);
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

            GameObjectPoolComponent.Instance.AddPlayerGameObject(self.Occ, self.trparent.gameObject);
            self.RecoverGameObject();
        }

        public static void LoadPrefab_2(this ChangeEquipHelper self,  string asset)
        {
            GameObjectPoolComponent.Instance.AddLoadQueue(asset, self.InstanceId, self.OnLoadGameObject);
        }

        public static void RecoverGameObject(this ChangeEquipHelper self)
        {
            List<string> changequips = UICommonHelper.ChangeEquip[self.Occ];
            for (int i = self.gameObjects.Count - 1; i >= 0; i--)
            {
                string assets = self.gameObjects[i].name;
                assets = assets.Substring(0, assets.Length - 7);
                int index = changequips.IndexOf(assets);
                if (index == -1)
                {
                    Log.Debug($"self.gameObjects[i].name == {self.gameObjects[i].name} : null");
                    GameObject.Destroy(self.gameObjects[i]);
                }
                else
                {
                    GameObjectPoolComponent.Instance.RecoverGameObject(self.GetPartsPath(self.Occ, assets), self.gameObjects[i]);
                }
            }
            self.gameObjects.Clear();
        }

        public static string GetPartsPath(this ChangeEquipHelper self, int occ, string assets)
        {
            return ABPathHelper.GetUnitPath($"Parts/{occ}/{assets}");
        }

        public static void LoadEquipment_2(this ChangeEquipHelper self, int occ, GameObject target)
        {
            if (occ == 2)
            {
                return;
            }

            if (target.transform.Find("ChangeEquip").gameObject.activeSelf)
            {
                return;
            }
            self.Occ = occ;
            self.gameObjects.Clear();
            self.skinnedMeshRenderers.Clear();
            self.trparent = target.transform;
            List<string> changequips = UICommonHelper.ChangeEquip[occ];
            foreach (var item in changequips)
            {
                self.LoadPrefab_2(self.GetPartsPath(occ, item));
            }
        }

        public static  void LoadEquipment(this ChangeEquipHelper self, GameObject target)
        {
            string lianPaths = "Component/Hero_lian";
            string shangyiPaths = "Component/Hero_shangyi";
            string meimaoPaths = "Component/Hero_meimao";
            string pifengPaths = "Component/Hero_pifeng";
            string toufaPaths = "Component/Hero_toufa";
            string xiashenPaths = "Component/Hero_xiashen";
            string xieziPaths = "Component/Hero_xiezi";
            string yangjingPaths = "Component/Hero_yanjing";

            List<Transform> oldBones = new List<Transform>();
            List<SkinnedMeshRenderer> skinnedMeshRenderers = new List<SkinnedMeshRenderer>();
            oldBones.AddRange(target.GetComponentsInChildren<Transform>());

            SkinnedMeshRenderer newSkinMR = target.GetComponentInChildren<SkinnedMeshRenderer>();
            List<GameObject> gameObjects = new List<GameObject>();

            //加载需要的8个子部件,每个部件都携带有骨骼,蒙皮
            Transform parent = target.transform;
            self.LoadPrefab_1(gameObjects, lianPaths, parent, skinnedMeshRenderers);
            self.LoadPrefab_1(gameObjects, shangyiPaths, parent, skinnedMeshRenderers);
            self.LoadPrefab_1(gameObjects, meimaoPaths, parent, skinnedMeshRenderers);
            self.LoadPrefab_1(gameObjects, pifengPaths, parent, skinnedMeshRenderers);
            self.LoadPrefab_1(gameObjects, toufaPaths, parent, skinnedMeshRenderers);
            self.LoadPrefab_1(gameObjects, xiashenPaths, parent, skinnedMeshRenderers);
            self.LoadPrefab_1(gameObjects, xieziPaths, parent, skinnedMeshRenderers);
            self.LoadPrefab_1(gameObjects, yangjingPaths, parent, skinnedMeshRenderers);
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
            foreach (var skinMR in skinnedMeshRenderers)
            {
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
            //构造新的漫反射贴图
            Texture2D newDiffuseTexture = new Texture2D(self.get2Pow(diffuseTextureWidth), self.get2Pow(diffuseTextureHeight));
            Texture2D[] texture2Ds = diffuseTextureList.ToArray();
            Rect[] packingResult = newDiffuseTexture.PackTextures(texture2Ds, 0);
            Vector2[] newUVs = new Vector2[newUVCount];

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

            // 设置漫反射贴图和UV
            newSkinMR.material.mainTexture = newDiffuseTexture;
            newSkinMR.sharedMesh.uv = newUVs;

            skinnedMeshRenderers.Clear();
            gameObjects.Clear();
        }
    }

    public  class ChangeEquipHelper : Entity, IAwake, IDestroy
    {
        //找到满足新贴图大小最合适的值,是2的倍数,这里限制了贴图分辨率最大为2的10次方,即1024*1024
        public int Occ;

        public bool ChangeEquip;
        public Transform trparent;
        public List<GameObject> gameObjects = new List<GameObject>();
        public List<SkinnedMeshRenderer> skinnedMeshRenderers = new List<SkinnedMeshRenderer>();
    }
}
