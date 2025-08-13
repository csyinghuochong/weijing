using ProtoBuf;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace ET
{
    public static class PathPositionHelper
    {

        public static PathPosition GetPositionRelativeToPath(this Unit unit, List<Vector3> path)
        {
            if (path == null || path.Count < 2)
            {
                return PathPosition.Ahead;
            }

            // 1. 计算玩家到路径起点和终点的距离
            Vector3 startPoint = path[0];
            Vector3 endPoint = path[path.Count - 1];
            float distanceToStart = Vector3.Distance(unit.Position, startPoint);
            float distanceToEnd = Vector3.Distance(unit.Position, endPoint);

            // 2. 计算路径总长度
            float totalPathLength = 0f;
            for (int i = 0; i < path.Count - 1; i++)
            {
                totalPathLength += Vector3.Distance(path[i], path[i + 1]);
            }

            // 3. 计算玩家到路径最近点的距离
            Vector3 closestPoint = GetClosestPointOnPath(unit.Position, path, out int segmentIndex, out float distanceAlongPath);

            // 4. 判断玩家是否在路径前方（第一个点之前）
            Vector3 firstSegmentDir = (path[1] - path[0]).normalized;
            Vector3 toPlayerFromStart = (unit.Position - path[0]).normalized;

            // 如果玩家在起点之前且方向相反
            if (Vector3.Dot(firstSegmentDir, toPlayerFromStart) < 0)
            {
                return PathPosition.Ahead;
            }

            // 5. 判断玩家是否在路径后方（超过最后一个点）
            Vector3 lastSegmentDir = (path[path.Count - 1] - path[path.Count - 2]).normalized;
            Vector3 toPlayerFromEnd = (unit.Position - path[path.Count - 1]).normalized;

            // 如果玩家在终点之后且方向相同
            if (Vector3.Dot(lastSegmentDir, toPlayerFromEnd) > 0)
            {
                return PathPosition.Behind;
            }

            // 6. 计算归一化位置和垂直距离
            float normalizedPosition = distanceAlongPath / totalPathLength;
            float verticalDistance = Vector3.Distance(unit.Position, closestPoint);

            // 7. 判断位置状态
            if (normalizedPosition < 0.1f)
            {
                // 在路径起点附近
                return (verticalDistance > 1.0f) ? PathPosition.Behind : PathPosition.Middle;
            }
            else if (normalizedPosition > 0.9f)
            {
                // 在路径终点附近
                return (verticalDistance > 1.0f) ? PathPosition.Ahead : PathPosition.Middle;
            }
            else
            {
                // 在路径中间
                return PathPosition.Middle;
            }
        }

        private static Vector3 GetClosestPointOnPath(Vector3 position, List<Vector3> path,
                                           out int closestSegmentIndex, out float distanceAlongPath)
        {
            closestSegmentIndex = 0;
            distanceAlongPath = 0f;
            float minDistance = float.MaxValue;
            Vector3 closestPoint = path[0];
            float accumulatedDistance = 0f;

            for (int i = 0; i < path.Count - 1; i++)
            {
                Vector3 segmentStart = path[i];
                Vector3 segmentEnd = path[i + 1];
                Vector3 segmentClosestPoint = GetClosestPointOnSegment(position, segmentStart, segmentEnd);

                float segmentDistance = Vector3.Distance(segmentStart, segmentEnd);
                float distanceToSegment = Vector3.Distance(position, segmentClosestPoint);

                if (distanceToSegment < minDistance)
                {
                    minDistance = distanceToSegment;
                    closestPoint = segmentClosestPoint;
                    closestSegmentIndex = i;

                    // 计算沿路径的距离
                    distanceAlongPath = accumulatedDistance +
                                       Vector3.Distance(segmentStart, segmentClosestPoint);
                }

                accumulatedDistance += segmentDistance;
            }

            return closestPoint;
        }

        private static Vector3 GetClosestPointOnSegment(Vector3 point, Vector3 segmentStart, Vector3 segmentEnd)
        {
            Vector3 segmentDirection = segmentEnd - segmentStart;
            float segmentLength = segmentDirection.magnitude;

            // 处理零长度线段
            if (segmentLength < 0.0001f)
            {
                return segmentStart;
            }

            segmentDirection.Normalize();

            float dotProduct = Vector3.Dot(point - segmentStart, segmentDirection);
            float t = Mathf.Clamp(dotProduct / segmentLength, 0f, 1f);

            return segmentStart + t * segmentDirection * segmentLength;
        }

    }

}