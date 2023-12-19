using System.Collections.Generic;
using UnityEngine;

namespace ET
{

    public class ChangeEquipHelperAwakeSystem : AwakeSystem<ChangeEquipHelper>
    {
        public override void Awake(ChangeEquipHelper self)
        {
            self.LoadCompleted = false;
            self.gameObjects.Clear();
            self.skinnedMeshRenderers.Clear();
            self.FashionBase.Clear();
        }
    }

    public class ChangeEquipHelperAwakeDestroy : DestroySystem<ChangeEquipHelper>
    {
        public override void Destroy(ChangeEquipHelper self)
        {
            self.LoadCompleted = false;
            if (self.NewMesh != null)
            {
                GameObject.DestroyImmediate(self.NewMesh);
            }
            self.NewMesh = null; 
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
            if (self.gameObjects.Count >= self.objectNames.Count)
            {
                self.OnAllLoadComplete();
            }
        }

        public static void OnLoadGameObject_2(this ChangeEquipHelper self, GameObject go, long formId)
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
            
            SkinnedMeshRenderer[] skinnedMeshRenderers = go.GetComponentsInChildren<SkinnedMeshRenderer>();
            foreach (var tmpRender in skinnedMeshRenderers)
            {
                self.ProcessMeshRender(tmpRender, self.trparentbone);
            }

            if (self.gameObjects.Count >= self.objectNames.Count)
            {
                self.OnAllLoadComplete_2();
            }
        }

        public static void OnAllLoadComplete_2(this ChangeEquipHelper self)
        {
            self.LoadCompleted = true;
            self.ChangeWeapon(self.WeaponId);
            self.RecoverGameObject();
        }

        public static void ProcessMeshRender(this ChangeEquipHelper self, SkinnedMeshRenderer thisRender, Transform rootObj)
        {
            GameObject newObj = new GameObject(thisRender.gameObject.name);
            if (self.UseLayer)
            {
                newObj.layer = self.trparent.gameObject.layer;
            }
            newObj.transform.parent = rootObj.transform;
            SkinnedMeshRenderer newRenderer = newObj.AddComponent<SkinnedMeshRenderer>();
            Transform[] myBones = new Transform[thisRender.bones.Length];
            for (int i = 0; i < thisRender.bones.Length; i++)
            {
                myBones[i] = self.FindChildByName(thisRender.bones[i].name, rootObj);
            }
            newRenderer.rootBone = rootObj;
            newRenderer.bones = myBones;
            newRenderer.sharedMesh = thisRender.sharedMesh;
            newRenderer.materials = thisRender.materials;
        }

        public static Transform FindChildByName(this ChangeEquipHelper self, string thisName, Transform thisObj)
        {
            Transform resultObj = null;
            if (thisObj.name == thisName)
            {
                return thisObj.transform;
            }

            for (int i = 0; i < thisObj.childCount; i++)
            {
                resultObj = self.FindChildByName(thisName, thisObj.GetChild(i));
                if (resultObj != null)
                {
                    return resultObj;
                }
            }
            return resultObj;
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

            self.NewMesh = new Mesh();

            newSkinMR.sharedMesh = self.NewMesh;
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
            self.LoadCompleted = true;
            self.ChangeWeapon( self.WeaponId );
            self.RecoverGameObject();
        }

        public static void LoadPrefab_2(this ChangeEquipHelper self,  string asset)
        {
            GameObjectPoolComponent.Instance.AddLoadQueue(asset, self.InstanceId, self.OnLoadGameObject_2);
        }

        public static void RecoverGameObject(this ChangeEquipHelper self)
        {
            Dictionary<string, string> fashionmap = new Dictionary<string, string>();  
            for (int i = 0; i < self.objectNames.Count; i++)
            {
                string[] assets = self.objectNames[i].Split('/');
                if (assets.Length != 6)
                {
                    continue;
                }
                
                string asset = assets[5].Substring(0, assets[5].Length - 7);
                fashionmap.Add(asset, self.objectNames[i]);
            }

            for (int i = self.gameObjects.Count - 1; i >= 0; i--)
            {
                string assets = self.gameObjects[i].name;
                assets = assets.Substring(0, assets.Length - 7);

                string assetpath = string.Empty;
                fashionmap.TryGetValue(assets, out assetpath);
                if (!string.IsNullOrEmpty(assetpath))
                {
                    GameObjectPoolComponent.Instance.RecoverGameObject(assetpath, self.gameObjects[i]);
                }
                else
                {
                    Log.Debug($"self.gameObjects[i].name == {self.gameObjects[i].name} : null");
                    GameObject.Destroy(self.gameObjects[i]);
                }

            }

            self.gameObjects.Clear();
        }

        public static List<string> GetPartsPath(this ChangeEquipHelper self, int occ, int subType, int fashonid)
        {
            List<string> assetlist = new List<string>();
            if (fashonid == 0)
            {
                List<string> assets = FashionHelper.FashionBaseTemplate(occ)[subType];
                for (int i = 0; i < assets.Count; i++)
                {
                    assetlist.Add(StringBuilderHelper.GetFashionDefault(occ, assets[i]));
                }
            }
            else
            {
                List<string> assets = FashionConfigCategory.Instance.GetModelList(fashonid);
                for (int i = 0; i < assets.Count; i++)
                {
                    assetlist.Add(StringBuilderHelper.GetFashionPath(assets[i]));
                }
            }

            return assetlist;
        }

        public static void ChangeWeapon(this ChangeEquipHelper self, int weaponid)
        {
            if (!self.LoadCompleted )
            {
                if (weaponid != 0)
                {
                    self.WeaponId = weaponid;
                }
                return;
            }
            UICommonHelper.ShowWeapon(self.trparent.gameObject,  self.Occ,self.EquipIndex,  weaponid, false);
        }

        public static void LoadEquipment(this ChangeEquipHelper self, GameObject target, List<int> fashionids, int occ)
        {
            OccupationConfig occupationConfig = OccupationConfigCategory.Instance.Get(occ);
            if (occupationConfig.ChangeEquip == 0)
            {
                return;
            }

            self.Occ = occ; 
            self.LoadCompleted = false;
            self.gameObjects.Clear();
            self.objectNames.Clear();
            self.skinnedMeshRenderers.Clear();
            self.trparent = target.transform;
            self.trparentbone = self.trparent.Find("BaseModel/Bip001");
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
                List<string> assetlist = self.GetPartsPath(occ, item.Key, item.Value);
                self.objectNames.AddRange(assetlist);
            }

            for (int i = 0; i < self.objectNames.Count; i++)
            {
                self.LoadPrefab_2(self.objectNames[i]);
            }
        }
    }


    public  class ChangeEquipHelper : Entity, IAwake, IDestroy
    {
        //找到满足新贴图大小最合适的值,是2的倍数,这里限制了贴图分辨率最大为2的10次方,即1024*1024
        public int Occ;

        public bool UseLayer;

        public int EquipIndex;

        public int WeaponId;

        public bool LoadCompleted;

        public Transform trparent;

        public Transform trparentbone;

        public Mesh NewMesh;

        public Texture2D newDiffuseTexture;

        public List<GameObject> gameObjects = new List<GameObject>();

        public List<string> objectNames = new List<string>();       

        public Dictionary<int, int> FashionBase = new Dictionary<int, int>();

        public List<SkinnedMeshRenderer> skinnedMeshRenderers = new List<SkinnedMeshRenderer>();
    }
}
