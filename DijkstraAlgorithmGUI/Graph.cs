using System;
using System.Collections.Generic;
using System.Drawing;

namespace SEMALG_actividad04
{
    public class Graph
    {
        List<Vertex> IVertexList;
        int[,] IAdjacencyMatrix;

        public Graph()
        {
            IVertexList = new List<Vertex>();
        }

        public Graph(List<Circle> circlesList)
        {
            foreach (Circle ICircle in circlesList)
                IVertexList.Add(new Vertex(ICircle, IVertexList.Count + 1));
        }

        public void SetWeights()
        {

            for (int i = 0; i < IVertexList.Count; ++i)
            {
                for (int j = 0; j < IVertexList[i].GetEdgesListCount(); ++j)
                {
                    IVertexList[i][j].SetWeight(ToolFunction.Distance(IVertexList[i].GetCirclePoint(), IVertexList[i][j].Destination.GetCirclePoint()));
                }
            }
        }

        public void CheckEdgePoints()
        {
            foreach (Vertex vertex in this.VertexList)
                foreach (Edge edge in vertex.GetEdges())
                    if (Math.Abs(edge.Path[0].X - vertex.GetCirclePoint().X) > 10)
                        edge.Path.Reverse();
        }

        public void Clear()
        {
            IVertexList.Clear();
        }

        public int[,] AdjacencyMatrix
        {
            get { return IAdjacencyMatrix; }
        }

        public void CreateIAdjacencyMatrix()
        {

            IAdjacencyMatrix = new int[IVertexList.Count, IVertexList.Count];

            Vertex actual;

            for (int i = 0; i < IVertexList.Count; ++i)
            {
                actual = IVertexList[i];

                for (int j = 0; j < IVertexList.Count; ++j)
                {
                    if (IdInEdge(j + 1, actual))
                    {
                        IAdjacencyMatrix[i, j] = 1;
                    }
                    else
                    {
                        IAdjacencyMatrix[i, j] = 0;
                    }
                }

                IAdjacencyMatrix[i, i] = 0;
            }
        }

        private bool IdInEdge(int id, Vertex vertex)
        {
            bool found = false;

            for (int i = 0; i < vertex.GetEdgesListCount(); ++i)
            {
                if (vertex.GetEdges()[i].Destination.ID == id)
                    found = true;
            }

            return found;
        }

        public int GetVertexCount()
        {
            return IVertexList.Count;
        }

        public List<Vertex> VertexList
        {
            get { return IVertexList; }
        }

        public Vertex this[int index]
        {
            set => IVertexList[index] = value;
            get => IVertexList[index];
        }

        public void AddVertex(Vertex _vertex)
        {
            IVertexList.Add(_vertex);
        }

        public void SortGraphInX()
        {
            Vertex tempVertex;

            for (int i = 0; i < IVertexList.Count; ++i)
            {
                for (int j = 0; j < IVertexList.Count - i - 1; ++j)
                {
                    if (IVertexList[j].GetCirclePoint().X > IVertexList[j + 1].GetCirclePoint().X)
                    {
                        tempVertex = IVertexList[j];
                        IVertexList[j] = IVertexList[j + 1];
                        IVertexList[j + 1] = tempVertex;
                    }
                }
            }
        }
    }

    public class Vertex
    {
        List<Edge> IEdgeList;
        Circle ICircle;
        public bool SortedEdges { set; get; }
        int IID { get; }
        public Vertex(Circle _circle, int _id)
        {
            this.ICircle = _circle;
            this.IID = _id;
            IEdgeList = new List<Edge>();
            SortedEdges = false;
        }

        public int GetEdgesListCount()
        {
            return IEdgeList.Count;
        }

        public Edge this[int index]
        {
            set => IEdgeList[index] = value;
            get => IEdgeList[index];
        }

        public void AddEdge(Edge _edge)
        {
            IEdgeList.Add(_edge);
        }

        public Circle Circle
        {
            get { return this.ICircle; }
        }

        public System.Drawing.Point GetCirclePoint()
        {
            return new System.Drawing.Point(ICircle.X, ICircle.Y);
        }

        public IReadOnlyList<Edge> GetEdges()
        {
            return IEdgeList.AsReadOnly();
        }

        public override string ToString()
        {
            return this.IID.ToString();
        }

        public int ID
        {
            get { return this.IID; }
        }
    }

    public class Edge
    {
        double IWeight;
        Vertex IDestination;
        Point IMiddleToDestination;
        List<Point> IPath;

        public Edge(double _weight, Vertex _vertexDestination, List<Point> _path)
        {
            this.IWeight = _weight;
            this.IDestination = _vertexDestination;
            this.IPath = _path;
        }

        public Vertex Destination
        {
            get { return this.IDestination; }
        }

        public void SetMiddle(Point _middle)
        {
            this.IMiddleToDestination = _middle;
        }

        public Point GetMiddlePoint
        {
            get { return this.IMiddleToDestination; }
        }

        public void SetWeight(double _weight)
        {
            this.IWeight = _weight;
        }

        public double Weight
        {
            get { return this.IWeight; }
        }

        public void SetPath(List<Point> path)
        {
            this.IPath = path;
        }

        public List<Point> Path
        {
            get { return this.IPath; }
        }
    }


}
