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
        for (int i = 0; i < v; i++)
            adj[i] = new List<int>();
    }

    
    public void AddEdge(int v, int w)
    {
        adj[v].Add(w); 
    }

    
    private void DFSUtil(int v, bool[] visited)
    {
        visited[v] = true;
        Console.Write(v + " ");

        foreach (int neighbor in adj[v])
        {
            if (!visited[neighbor])
                DFSUtil(neighbor, visited);
        }
    }

    
    public void DFS(int start)
    {
        bool[] visited = new bool[V];
        Console.WriteLine("DFS starting from node " + start + ":");
        DFSUtil(start, visited);
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

        g.DFS(0); 

        Console.WriteLine();
        Console.ReadLine(); 
    }
}
