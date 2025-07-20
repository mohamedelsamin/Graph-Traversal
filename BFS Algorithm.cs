using System;
using System.Collections.Generic;

class Graph
{
    private int V;
    private List<int>[] adj; 

    public Graph(int v)
    {
        V = v;
        adj = new List<int>[v];
        for (int i = 0; i < v; ++i)
            adj[i] = new List<int>();
    }

    public void AddEdge(int v, int w)
    {
        adj[v].Add(w);
    }

    public void BFS(int start)
    {
        bool[] visited = new bool[V];
        Queue<int> queue = new Queue<int>();

        visited[start] = true;
        queue.Enqueue(start);

        Console.WriteLine("BFS starting from node " + start + ":");

        while (queue.Count != 0)
        {
            int node = queue.Dequeue();
            Console.Write(node + " ");

            foreach (int neighbor in adj[node])
            {
                if (!visited[neighbor])
                {
                    visited[neighbor] = true;
                    queue.Enqueue(neighbor);
                }
            }
        }
    }

    static void Main()
    {
        Graph g = new Graph(6);
        g.AddEdge(0, 1);
        g.AddEdge(0, 2);
        g.AddEdge(1, 3);
        g.AddEdge(1, 4);
        g.AddEdge(2, 4);
        g.AddEdge(3, 5);
        g.AddEdge(4, 5);

        g.BFS(0); 

        Console.WriteLine(); 
        Console.ReadLine();
    }
}
