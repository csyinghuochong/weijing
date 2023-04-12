using System;
using System.Collections.Generic;

namespace ET
{


    public class ReddotViewComponentAwakeSystem : AwakeSystem<ReddotViewComponent>
    {
        public override void Awake(ReddotViewComponent self)
        {

            ReddotData[] reddot = new ReddotData[]
            {   
                new ReddotData { key = ReddotType.Friend, children = new int[2] { ReddotType.FriendApply, ReddotType.UnionMy } },
                new ReddotData { key = ReddotType.Team, children = new int[1] { ReddotType.TeamApply } },
                new ReddotData { key = ReddotType.UnionMy, children = new int[1] { ReddotType.UnionApply } },
                new ReddotData { key = ReddotType.Email, children = new int[0] {  } },
                new ReddotData { key = ReddotType.RolePoint, children = new int[0] {  } },
            };

            self.Init(reddot);
        }
    }


    public class ReddotViewComponentDestroySystem : DestroySystem<ReddotViewComponent>
    {
        public override void Destroy(ReddotViewComponent self)
        {
            self.m_ReddotNodeDic = null;
        }
    }

    public static class ReddotViewComponentSystem
    {

        /// <summary>
        /// 初始化
        /// </summary>
        /// <param name="datas">一般应由红点编辑生成的json文件获得，也可以自定义</param>
        public static void Init(this ReddotViewComponent self, ReddotData[] datas)
        {
            self.m_ReddotNodeDic = new Dictionary<int, ReddotNode>();
            foreach (var data in datas)
            {
                if (!self.m_ReddotNodeDic.TryGetValue(data.key, out ReddotNode node))
                {
                    node = new ReddotNode(data.key);
                    self.m_ReddotNodeDic.Add(data.key, node);
                }

                if (data.children != null)
                {
                    foreach (var child in data.children)
                    {
                        if (!self.m_ReddotNodeDic.TryGetValue(child, out ReddotNode childNode))
                        {
                            childNode = new ReddotNode(child);
                            self.m_ReddotNodeDic.Add(child, childNode);
                        }
                        node.AddChild(childNode);
                    }
                }
            }
        }

        /// <summary>
        /// 编辑节点状态
        /// </summary>
        /// <param name="key"></param>
        /// <param name="changeValue"></param>
        public static void ChangeCountReddot(this ReddotViewComponent self, int key, int changeValue)
        {
            if (!self.m_ReddotNodeDic.TryGetValue(key, out ReddotNode reddotNode))
            {
                throw new Exception($"[Reddot System] there is no node which key is '{key}' in reddot tree，please add node to reddot tree or modify key");
            }

            reddotNode.ChangeCount(changeValue);
        }

        /// <summary>
        /// 注册UI
        /// </summary>
        /// <param name="key">键值</param>
        /// <param name="reddot">红点组件</param>
        public static void RegisterReddot(this ReddotViewComponent self, int key, Action<int> reddot)
        {
            if (self.m_ReddotNodeDic.TryGetValue(key, out ReddotNode reddotNode))
            {
                reddotNode.RegisterReddot(reddot);
                reddotNode.ReddotAction();//有注册的时候,执行下派发
            }
            else
            {
                throw new Exception($"[Reddot System] there is no node which key is '{key}' in reddot tree，please add node to reddot tree or modify key");
            }
        }

        /// <summary>
        /// 移除UI
        /// </summary>
        /// <param name="key">键值</param>
        /// <param name="reddot">红点组件</param>
        public static void UnRegisterReddot(this ReddotViewComponent self,int key, Action<int> reddot)
        {
            if (self.m_ReddotNodeDic.TryGetValue(key, out ReddotNode reddotNode))
            {
                reddotNode.UnRegisterReddot(reddot);

            }
            else
            {
                throw new Exception($"[Reddot System] there is no node which key is '{key}' in reddot tree，please add node to reddot tree or modify key");
            }
        }

        /// <summary>
        /// 获取键值对应的节点红点数目
        /// </summary>
        /// <param name="key">键值</param>
        /// <returns>状态</returns>
        public static int GetKeyReddotCount(this ReddotViewComponent self, int key)
        {
            if (self.m_ReddotNodeDic.TryGetValue(key, out ReddotNode reddotNode))
            {
                return reddotNode.ReddotCount;
            }
            else
            {
                throw new Exception($"[Reddot System] there is no node which key is '{key}' in reddot tree，please add node to reddot tree or modify key");
            }
        }
    }
}
