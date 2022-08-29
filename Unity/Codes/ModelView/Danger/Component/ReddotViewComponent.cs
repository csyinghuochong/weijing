using System;
using System.Collections.Generic;

namespace ET
{

    /// <summary>
    /// 红点数据
    /// </summary>
    public class ReddotData
    {
        public int key;
        public int[] children;

    }

    /// <summary>
    /// 红点树节点
    /// </summary>
    public class ReddotNode
    {
        private int m_reddotCount;
        private List<ReddotNode> m_children;
        private List<ReddotNode> m_parents;

        private Action<int> reddotAction;
        public int Key { get; private set; }

        public int ReddotCount
        {
            get
            {
                return m_reddotCount;
            }
            private set
            {
                if (m_reddotCount != value)
                {
                    int changeValue = value - m_reddotCount;//记录变化值

                    if (value < 0)
                    {

                        m_reddotCount = 0;
                        throw new Exception($"[红点系统] 不允许红点数目小于0 节点key为[{Key}]");
                    }
                    else
                    {
                        m_reddotCount = value;
                    }

                    if (reddotAction != null)
                    {
                        reddotAction(m_reddotCount);
                    }

                    if (m_parents != null)
                    {
                        foreach (var node in m_parents)
                        {
                            node.ReddotCount += changeValue;
                        }
                    }
                }
            }
        }

        public bool IsLeafNode
        {
            get
            {
                return m_children == null || m_children.Count == 0;
            }
        }

        public ReddotNode(int key)
        {
            this.Key = key;
        }

        /// <summary>
        /// 设置节点红点数量
        /// </summary>
        /// <param name="finalCount">红点数</param>
        public void Mark(int finalCount)
        {
            if (!IsLeafNode)
            {
                throw new Exception($"[红点系统] 不允许标记非叶子节点 节点key为[{Key}]");
            }

            ReddotCount = finalCount;
        }

        /// <summary>
        /// 设置节点红点改变数量
        /// </summary>
        /// <param name="changeValue">红点变化值,负数为减少多少,正数为增加多少</param>
        public void ChangeCount(int changeValue)
        {
            if (!IsLeafNode)
            {
                throw new Exception($"[红点系统] 不允许标记非叶子节点 节点key为[{Key}]");
            }
            //if (ReddotCount + changeValue < 0)
            //{
            //    changeValue = 0 - ReddotCount;
            //}
            //ReddotCount += changeValue;
            ReddotCount = changeValue;
        }

        public void AddChild(ReddotNode node)
        {
            if (m_children is null)
            {
                m_children = new List<ReddotNode>();
            }
            m_children.Add(node);

            if (node.m_parents is null)
            {
                node.m_parents = new List<ReddotNode>();
            }
            node.m_parents.Add(this);
        }
        public void RegisterReddot(Action<int> fun)
        {
            reddotAction += fun;
        }

        public void UnRegisterReddot(Action<int> fun)
        {
            if (reddotAction != null)
            {
                reddotAction -= fun;//可能这个事件就注册过
            }
        }
        public void ReddotAction()
        {
            if (reddotAction != null)
            {
                reddotAction(m_reddotCount);
            }
        }
    }

    //有些系统需要打开才请求对应的数据，红点放在后端
    public class ReddotViewComponent : Entity, IAwake, IDestroy
    {
        public Dictionary<int, ReddotNode> m_ReddotNodeDic;
    }
}
