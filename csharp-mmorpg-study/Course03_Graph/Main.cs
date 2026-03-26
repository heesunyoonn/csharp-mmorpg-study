namespace Course03_Graph
{
    class Main
    {
        public void Run()
        {
            /*
             * 알고리즘 실행
             */
            //PracticeDFS dfs= new DFSPractice();
            //PracticeBFS bfs= new BFSPractice();
            PracticeDijkstra dijkstra = new PracticeDijkstra();

            //bfs.Run();
            //dfs.Run();
            dijkstra.Run();


            /*
             * 게임 실행
             */
            //GameMap map = new GameMap();
            //map.GameLoop();

        }

    }
}

