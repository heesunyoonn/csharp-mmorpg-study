using System;
using System.Collections.Generic;
using System.Text;

namespace Course03_Graph
{
    class Graph
    {
        //그래프-행렬
        public static int[,] matrix = new int[6, 6]
        {
            {0, 1, 0, 1, 0, 0},
            {1, 0, 1, 1, 0, 0},
            {0, 1, 0, 0, 0, 0},
            {1, 1, 0, 0, 1, 0},
            {0, 0, 0, 1, 0, 1},
            {0, 0, 0, 0, 1, 0},
        };

        //그래프-리스트
        public static List<int>[] list = new List<int>[]
        {
            new List<int>() {1, 3}, //연결된 정점 배열
            new List<int>() {0, 2, 3},
            new List<int>() {1},
            new List<int>() {0, 1, 4},
            new List<int>() {3, 5},
            new List<int>() {4},
        };


        //다익스트라 그래프-행렬 (가중치)
        public static int[,] DijkstraMatrix = new int[6, 6]
        {
            {-1, 15, -1, 35, -1, -1},
            {15, -1, 05, 10, -1, -1},
            {-1, 05, -1, -1, -1, -1},
            {35, 10, -1, -1, 05, -1},
            {-1, -1, -1, 05, -1, 05},
            {-1, -1, -1, -1, 05, -1},
        };





    }

}
