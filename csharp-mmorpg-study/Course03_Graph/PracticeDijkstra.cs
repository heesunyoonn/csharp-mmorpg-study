using System;
using System.Collections.Generic;
using System.Text;

namespace Course03_Graph
{
    internal class PracticeDijkstra
    {
        public void Run()
        {
            Dijkstra(0);
        }


        private void Dijkstra(int start)
        {
            bool[] visited = new bool[6];
            int[] distance = new int[6];

            //distance가 0일 때 정점끼리 연결이 안되서 0일수도 있으므로 큰 수로 초기화)
            Array.Fill(distance, Int32.MaxValue);

            distance[start] = 0;
            int count = Graph.DijkstraMatrix.GetLength(0);



            /*
             *TODO: 가장 좋은 정점 후보를 찾는다.
             *1. 연결이 되어있어야 하고,
             *2. 방문한 적이 없어야 한다.
             *3. 최단 거리여야한다.
             *
             *TODO: 방문하고, 거리를 추가한다.
             *
             */
            while (true)
            {
                for (int i = 0; i < count; i++)
                {
                    //TODO: start 지점부터 각 정점의 최단거리를 distance에 저장하면서 반복문 돌면 됨


                }

            }





        }
    }
}
