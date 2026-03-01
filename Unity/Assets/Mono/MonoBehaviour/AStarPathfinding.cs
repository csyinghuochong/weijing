using System.Collections.Generic;
using UnityEngine;


// 网格节点类，存储每个格子的信息
public class AStarNode
{
    // 节点的网格坐标（x列，y行）
    public int gridX;
    public int gridY;

    // A*核心参数
    public int gCost; // 起点到当前节点的成本
    public int hCost; // 当前节点到终点的预估成本
    public int fCost => gCost + hCost; // 总代价

    public bool isObstacle; // 是否是障碍物（不可通行）
    public AStarNode parent; // 父节点（用于回溯路径）
    public Vector3 worldPos; // 节点的世界坐标（用于Unity显示）

    public AStarNode(int x, int y, Vector3 pos, bool obstacle)
    {
        gridX = x;
        gridY = y;
        worldPos = pos;
        isObstacle = obstacle;
    }

    // 手动计算FCost（防止属性不更新的情况）
    public void CalculateFCost()
    {
        //fCost = gCost + hCost;
    }
}

public class AStarPathfinding : MonoBehaviour
{
    [Header("地图设置")]
    public int gridWidth = 10; // 网格宽度（列数）
    public int gridHeight = 10; // 网格高度（行数）
    public float nodeSize = 1f; // 每个格子的大小
    public Transform startPos; // 起点（Unity场景中赋值）
    public Transform targetPos; // 终点（Unity场景中赋值）
    public LayerMask obstacleLayer; // 障碍物层（Unity中设置）

    private AStarNode[,] grid; // 网格数组
    private List<AStarNode> openList; // 待检测节点
    private List<AStarNode> closeList; // 已检测节点

    void Start()
    {
        // 初始化网格
        CreateGrid();
        // 寻路并绘制路径
        List<AStarNode> path = FindPath(startPos.position, targetPos.position);
        DrawPath(path);
    }

    // 1. 创建网格地图
    void CreateGrid()
    {
        grid = new AStarNode[gridWidth, gridHeight];
        Vector3 worldBottomLeft = transform.position - Vector3.right * gridWidth * nodeSize / 2 - Vector3.forward * gridHeight * nodeSize / 2;

        // 遍历每个格子，初始化节点
        for (int x = 0; x < gridWidth; x++)
        {
            for (int y = 0; y < gridHeight; y++)
            {
                // 计算当前节点的世界坐标
                Vector3 worldPos = worldBottomLeft + Vector3.right * (x * nodeSize + nodeSize / 2) + Vector3.forward * (y * nodeSize + nodeSize / 2);
                // 检测是否是障碍物（射线检测）
                bool isObstacle = Physics.CheckSphere(worldPos, nodeSize / 4, obstacleLayer);

                // 创建节点
                grid[x, y] = new AStarNode(x, y, worldPos, isObstacle);
            }
        }
    }

    // 2. 核心：A*寻路算法
    public List<AStarNode> FindPath(Vector3 startWorldPos, Vector3 targetWorldPos)
    {
        // 1. 转换世界坐标为网格节点
        AStarNode startNode = GetNodeFromWorldPos(startWorldPos);
        AStarNode targetNode = GetNodeFromWorldPos(targetWorldPos);

        // 2. 初始化Open/Close列表
        openList = new List<AStarNode>() { startNode };
        closeList = new List<AStarNode>();

        // 3. 初始化所有节点的GCost为最大值，父节点为空
        for (int x = 0; x < gridWidth; x++)
        {
            for (int y = 0; y < gridHeight; y++)
            {
                AStarNode node = grid[x, y];
                node.gCost = int.MaxValue;
                node.parent = null;
            }
        }

        // 4. 起点初始化
        startNode.gCost = 0;
        startNode.hCost = CalculateHCost(startNode, targetNode);

        // 5. 核心循环：遍历OpenList
        while (openList.Count > 0)
        {
            // 5.1 找到OpenList中FCost最小的节点（当前节点）
            AStarNode currentNode = GetLowestFCostNode(openList);

            // 5.2 如果当前节点是终点，回溯路径并返回
            if (currentNode == targetNode)
            {
                return RetracePath(startNode, targetNode);
            }

            // 5.3 将当前节点从OpenList移到CloseList
            openList.Remove(currentNode);
            closeList.Add(currentNode);

            // 5.4 遍历当前节点的相邻节点
            foreach (AStarNode neighborNode in GetNeighborNodes(currentNode))
            {
                // 跳过障碍物或已检测的节点
                if (neighborNode.isObstacle || closeList.Contains(neighborNode))
                {
                    continue;
                }

                // 5.5 计算从起点到相邻节点的临时GCost
                int tentativeGCost = currentNode.gCost + CalculateHCost(currentNode, neighborNode);

                // 5.6 如果临时GCost更小，更新相邻节点
                if (tentativeGCost < neighborNode.gCost)
                {
                    neighborNode.parent = currentNode;
                    neighborNode.gCost = tentativeGCost;
                    neighborNode.hCost = CalculateHCost(neighborNode, targetNode);

                    // 5.7 如果相邻节点不在OpenList，加入
                    if (!openList.Contains(neighborNode))
                    {
                        openList.Add(neighborNode);
                    }
                }
            }
        }

        // 6. 没有找到路径
        Debug.Log("未找到有效路径！");
        return null;
    }

    // 辅助：计算HCost（曼哈顿距离，适合上下左右移动）
    private int CalculateHCost(AStarNode a, AStarNode b)
    {
        int dx = Mathf.Abs(a.gridX - b.gridX);
        int dy = Mathf.Abs(a.gridY - b.gridY);
        return 10 * (dx + dy); // 10是移动一格的基础成本
    }

    // 辅助：找到OpenList中FCost最小的节点
    private AStarNode GetLowestFCostNode(List<AStarNode> nodeList)
    {
        AStarNode lowestFCostNode = nodeList[0];
        for (int i = 1; i < nodeList.Count; i++)
        {
            if (nodeList[i].fCost < lowestFCostNode.fCost ||
                (nodeList[i].fCost == lowestFCostNode.fCost && nodeList[i].hCost < lowestFCostNode.hCost))
            {
                lowestFCostNode = nodeList[i];
            }
        }
        return lowestFCostNode;
    }

    // 辅助：获取相邻节点（上下左右，可扩展为8方向）
    private List<AStarNode> GetNeighborNodes(AStarNode currentNode)
    {
        List<AStarNode> neighbors = new List<AStarNode>();

        // 上
        if (currentNode.gridY + 1 < gridHeight)
        {
            neighbors.Add(grid[currentNode.gridX, currentNode.gridY + 1]);
        }
        // 下
        if (currentNode.gridY - 1 >= 0)
        {
            neighbors.Add(grid[currentNode.gridX, currentNode.gridY - 1]);
        }
        // 左
        if (currentNode.gridX - 1 >= 0)
        {
            neighbors.Add(grid[currentNode.gridX - 1, currentNode.gridY]);
        }
        // 右
        if (currentNode.gridX + 1 < gridWidth)
        {
            neighbors.Add(grid[currentNode.gridX + 1, currentNode.gridY]);
        }

        return neighbors;
    }

    // 辅助：回溯路径（从终点到起点，再反转）
    private List<AStarNode> RetracePath(AStarNode startNode, AStarNode endNode)
    {
        List<AStarNode> path = new List<AStarNode>();
        AStarNode currentNode = endNode;

        // 从终点回溯到起点
        while (currentNode != startNode)
        {
            path.Add(currentNode);
            currentNode = currentNode.parent;
        }

        // 反转路径（起点→终点）
        path.Reverse();
        return path;
    }

    // 辅助：世界坐标转网格节点
    private AStarNode GetNodeFromWorldPos(Vector3 worldPos)
    {
        // 计算归一化的坐标（0~1）
        float percentX = (worldPos.x + gridWidth * nodeSize / 2) / (gridWidth * nodeSize);
        float percentY = (worldPos.z + gridHeight * nodeSize / 2) / (gridHeight * nodeSize);

        // 限制在0~1之间，防止越界
        percentX = Mathf.Clamp01(percentX);
        percentY = Mathf.Clamp01(percentY);

        // 转换为网格坐标
        int x = Mathf.RoundToInt((gridWidth - 1) * percentX);
        int y = Mathf.RoundToInt((gridHeight - 1) * percentY);

        return grid[x, y];
    }

    // 辅助：Gizmos绘制路径（Unity场景视图可视化）
    void DrawPath(List<AStarNode> path)
    {
        if (path == null) return;

        for (int i = 0; i < path.Count - 1; i++)
        {
            Debug.DrawLine(path[i].worldPos, path[i + 1].worldPos, Color.green, 10f);
        }
    }

    // Gizmos绘制网格（场景视图可视化）
    void OnDrawGizmos()
    {
        // 绘制网格范围
        Gizmos.DrawWireCube(transform.position, new Vector3(gridWidth * nodeSize, 1f, gridHeight * nodeSize));

        if (grid != null)
        {
            AStarNode startNode = GetNodeFromWorldPos(startPos.position);
            AStarNode targetNode = GetNodeFromWorldPos(targetPos.position);

            // 遍历所有节点
            foreach (AStarNode node in grid)
            {
                // 障碍物：红色，普通节点：白色
                Gizmos.color = node.isObstacle ? Color.red : Color.white;

                // 如果是起点：绿色，终点：蓝色
                if (node == startNode) Gizmos.color = Color.green;
                if (node == targetNode) Gizmos.color = Color.blue;

                // 绘制节点（立方体）
                Gizmos.DrawCube(node.worldPos, Vector3.one * (nodeSize - 0.1f));
            }
        }
    }
}