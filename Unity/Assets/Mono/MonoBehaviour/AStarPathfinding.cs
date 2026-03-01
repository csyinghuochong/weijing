using System.Collections.Generic;
using UnityEngine;


// 单个网格节点的属性
public class Node
{
    public bool isWalkable; // 是否可通行
    public Vector3 worldPosition; // 世界坐标
    public int gridX; // 网格X坐标
    public int gridY; // 网格Y坐标

    // A星核心参数
    public int gCost; // 起点到当前节点的成本
    public int hCost; // 当前节点到终点的预估成本
    public int fCost => gCost + hCost; // 总成本
    public Node parent; // 父节点（用于回溯路径）

    public Node(bool _isWalkable, Vector3 _worldPos, int _gridX, int _gridY)
    {
        isWalkable = _isWalkable;
        worldPosition = _worldPos;
        gridX = _gridX;
        gridY = _gridY;
    }
}

public class AStarPathfinding : MonoBehaviour
{
    // 网格配置
    public Transform seeker; // 寻路者（如玩家）
    public Transform target; // 目标点（如敌人）
    public Vector2 gridWorldSize; // 网格世界尺寸
    public float nodeRadius; // 节点半径
    public LayerMask unwalkableMask; // 不可通行层（如障碍物）

    private Node[,] grid; // 网格二维数组
    private float nodeDiameter; // 节点直径
    private int gridSizeX, gridSizeY; // 网格行列数

    private void Awake()
    {
        nodeDiameter = nodeRadius * 2;
        // 计算网格行列数（向下取整）
        gridSizeX = Mathf.RoundToInt(gridWorldSize.x / nodeDiameter);
        gridSizeY = Mathf.RoundToInt(gridWorldSize.y / nodeDiameter);
        CreateGrid();
    }

    // 创建网格
    private void CreateGrid()
    {
        grid = new Node[gridSizeX, gridSizeY];
        Vector3 worldBottomLeft = transform.position - Vector3.right * gridWorldSize.x / 2 - Vector3.forward * gridWorldSize.y / 2;

        for (int x = 0; x < gridSizeX; x++)
        {
            for (int y = 0; y < gridSizeY; y++)
            {
                // 计算节点世界坐标
                Vector3 worldPoint = worldBottomLeft + Vector3.right * (x * nodeDiameter + nodeRadius) + Vector3.forward * (y * nodeDiameter + nodeRadius);
                // 检测节点是否可通行（射线检测）
                bool walkable = !Physics.CheckSphere(worldPoint, nodeRadius, unwalkableMask);
                grid[x, y] = new Node(walkable, worldPoint, x, y);
            }
        }
    }

    // 获取节点的相邻节点
    private List<Node> GetNeighbours(Node node)
    {
        List<Node> neighbours = new List<Node>();

        for (int x = -1; x <= 1; x++)
        {
            for (int y = -1; y <= 1; y++)
            {
                // 跳过自身
                if (x == 0 && y == 0) continue;

                int checkX = node.gridX + x;
                int checkY = node.gridY + y;

                // 检查是否在网格范围内
                if (checkX >= 0 && checkX < gridSizeX && checkY >= 0 && checkY < gridSizeY)
                {
                    neighbours.Add(grid[checkX, checkY]);
                }
            }
        }

        return neighbours;
    }

    // 核心：A星寻路算法
    public List<Node> FindPath(Vector3 startPos, Vector3 targetPos)
    {
        // 转换世界坐标为网格节点
        Node startNode = NodeFromWorldPoint(startPos);
        Node targetNode = NodeFromWorldPoint(targetPos);

        // 开放列表（待检查的节点）、关闭列表（已检查的节点）
        List<Node> openSet = new List<Node>();
        HashSet<Node> closedSet = new HashSet<Node>();
        openSet.Add(startNode);

        while (openSet.Count > 0)
        {
            // 找到开放列表中fCost最小的节点
            Node currentNode = openSet[0];
            for (int i = 1; i < openSet.Count; i++)
            {
                if (openSet[i].fCost < currentNode.fCost ||
                    (openSet[i].fCost == currentNode.fCost && openSet[i].hCost < currentNode.hCost))
                {
                    currentNode = openSet[i];
                }
            }

            openSet.Remove(currentNode);
            closedSet.Add(currentNode);

            // 找到目标节点，回溯路径
            if (currentNode == targetNode)
            {
                return RetracePath(startNode, targetNode);
            }

            // 遍历相邻节点
            foreach (Node neighbour in GetNeighbours(currentNode))
            {
                // 跳过不可通行或已检查的节点
                if (!neighbour.isWalkable || closedSet.Contains(neighbour))
                {
                    continue;
                }

                // 计算新的gCost
                int newMovementCostToNeighbour = currentNode.gCost + GetDistance(currentNode, neighbour);
                if (newMovementCostToNeighbour < neighbour.gCost || !openSet.Contains(neighbour))
                {
                    neighbour.gCost = newMovementCostToNeighbour;
                    neighbour.hCost = GetDistance(neighbour, targetNode);
                    neighbour.parent = currentNode;

                    if (!openSet.Contains(neighbour))
                    {
                        openSet.Add(neighbour);
                    }
                }
            }
        }

        // 没有找到路径返回空
        return null;
    }

    // 回溯路径（从终点到起点）
    private List<Node> RetracePath(Node startNode, Node endNode)
    {
        List<Node> path = new List<Node>();
        Node currentNode = endNode;

        while (currentNode != startNode)
        {
            path.Add(currentNode);
            currentNode = currentNode.parent;
        }

        // 反转路径（从起点到终点）
        path.Reverse();
        return path;
    }

    // 计算两个节点的曼哈顿距离（启发函数）
    private int GetDistance(Node nodeA, Node nodeB)
    {
        int dstX = Mathf.Abs(nodeA.gridX - nodeB.gridX);
        int dstY = Mathf.Abs(nodeA.gridY - nodeB.gridY);
        return 10 * (dstX + dstY); // 10为基础移动成本（对角线可设为14）
    }

    // 世界坐标转网格节点
    public Node NodeFromWorldPoint(Vector3 worldPosition)
    {
        float percentX = (worldPosition.x + gridWorldSize.x / 2) / gridWorldSize.x;
        float percentY = (worldPosition.z + gridWorldSize.y / 2) / gridWorldSize.y;
        percentX = Mathf.Clamp01(percentX);
        percentY = Mathf.Clamp01(percentY);

        int x = Mathf.RoundToInt((gridSizeX - 1) * percentX);
        int y = Mathf.RoundToInt((gridSizeY - 1) * percentY);
        return grid[x, y];
    }

    // Gizmos可视化网格和路径（调试用）
    private void OnDrawGizmos()
    {
        // 绘制网格范围
        Gizmos.DrawWireCube(transform.position, new Vector3(gridWorldSize.x, 1, gridWorldSize.y));

        if (grid != null)
        {
            Node seekerNode = NodeFromWorldPoint(seeker.position);
            Node targetNode = NodeFromWorldPoint(target.position);

            // 绘制所有节点
            foreach (Node n in grid)
            {
                // 可通行=白色，不可通行=红色
                Gizmos.color = n.isWalkable ? Color.white : Color.red;

                // 标记起点（绿色）、终点（黄色）
                if (seekerNode == n) Gizmos.color = Color.green;
                if (targetNode == n) Gizmos.color = Color.yellow;

                Gizmos.DrawCube(n.worldPosition, Vector3.one * (nodeDiameter - 0.1f));
            }

            // 绘制寻路结果
            List<Node> path = FindPath(seeker.position, target.position);
            if (path != null)
            {
                for (int i = 0; i < path.Count - 1; i++)
                {
                    Gizmos.color = Color.blue;
                    Gizmos.DrawLine(path[i].worldPosition, path[i + 1].worldPosition);
                }
            }
        }
    }
}