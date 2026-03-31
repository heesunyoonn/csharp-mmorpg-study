using System;
using System.Collections.Generic;
using System.Text;

namespace Course02_DataStructureAndAlgorithm
{
    internal class PracticeDijkstra
    {
        public void Run()
        {
            Dijkstra(0);
        }

        /*
         * 다익스트라 알고리즘은 단순히 local 노드에서 최단 거리를 따라가는게 아님.
         * 전체 후보 (global)에서 최단거리를 확정해가는 알고리즘임.
         */
        private void Dijkstra(int start)
        {
            bool[] visited = new bool[6];
            int[] distance = new int[6];
            int[] parent = new int[6];

            Array.Fill(distance, Int32.MaxValue);
            distance[start] = 0;
            parent[start] = start;
            int row = Graph.DijkstraMatrix.GetLength(0);

            while (true)
            {
                //[1] 전체 노드 탐색 -> 최단 노드 선택
                int now = -1;
                int closest = Int32.MaxValue;
                for (int i = 0; i < row; i++)
                {
                    if (visited[i])
                        continue;

                    if (distance[i] == Int32.MaxValue || distance[i] >= closest)
                        continue;

                    closest = distance[i];
                    now = i;
                }

                //이미 모두 방문했다면 while문 엑시트
                if (now == -1)
                    break;


                visited[now] = true;

                /*
                 * 현재 정점을 기준으로 인접한 정점까지의 거리를 각 distance[i]에 저장.
                 * 기존 거리보다 짧으면 갱신
                 */
                for (int next = 0; next < row; next++)
                {
                    if (Graph.DijkstraMatrix[now, next] == -1)
                        continue;

                    if (visited[next])
                        continue;

                    int nextDistance = distance[now] + Graph.DijkstraMatrix[now, next];
                    if (nextDistance < distance[next])
                    {
                        distance[next] = nextDistance;
                        parent[next] = now;
                    }
                }
            }
        }
    }
}
