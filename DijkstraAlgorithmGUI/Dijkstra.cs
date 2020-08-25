using System.Collections.Generic;

namespace SEMALG_actividad04
{
    public class Dijkstra
    {
        List<Vertex> Selections;
        Graph Graph;
        Vertex InitialVertex;
        Dictionary<Vertex, DijkstraValue> DijkstraValues;

        public Dijkstra(Graph graph, Vertex initialVertex)
        {
            this.Selections = new List<Vertex>();
            this.Graph = graph;
            this.InitialVertex = initialVertex;
            this.DijkstraValues = new Dictionary<Vertex, DijkstraValue>();
        }

        public void DijkstraAlgorithm()
        {
            ClearPreviousData();

            InitializeDijkstraVector();
            Vertex minWeighted;

            while(!IsSolution())
            {
                UpdateDefinitiveValues();

                minWeighted = SelectMinDijkstraValue();

                if (minWeighted == null)
                    break;

                UpdateDijkstraVector(minWeighted);
                Selections.Add(minWeighted);
            }
        }

        private void InitializeDijkstraVector()
        {
            foreach (Vertex vertex in Graph.VertexList)
            {
                if (vertex.ID != InitialVertex.ID)
                    DijkstraValues[vertex] = new DijkstraValue(ToolFunction.INFINITE, false, vertex);
                else
                    DijkstraValues[vertex] = new DijkstraValue(0, false, vertex);
            }
        }

        private void UpdateDefinitiveValues()
        {
            foreach (Vertex vertex in this.Selections)
                DijkstraValues[vertex].IsDefinitive = true;
        }

        private bool IsSolution()
        {
            foreach (var key in DijkstraValues)
                if (!key.Value.IsDefinitive)
                    return false;

            return true;
        }

        private Vertex SelectMinDijkstraValue()
        {
            double minWeight = ToolFunction.INFINITE;
            Vertex minVertex = null;

            foreach (var key in DijkstraValues)
            {
                if (!key.Value.IsDefinitive)
                {
                    if (key.Value.Weight < minWeight)
                    {
                        minWeight = key.Value.Weight;
                        minVertex = key.Value.Vertex;
                    }
                }
            }

            return minVertex;
        }

        private void UpdateDijkstraVector(Vertex selectedVertex)
        {
            double totalWeight;

            foreach (Edge edge in selectedVertex.GetEdges())
            {
                if (!DijkstraValues[edge.Destination].IsDefinitive)
                {
                    totalWeight = DijkstraValues[selectedVertex].Weight + edge.Weight;

                    if (totalWeight < DijkstraValues[edge.Destination].Weight)
                    {
                        DijkstraValues[edge.Destination].Weight = totalWeight;
                        DijkstraValues[edge.Destination].UpdatedBy = selectedVertex;
                    }
                }
            }
        }

        public List<Vertex> BuildPath(Vertex destination)
        {
            List<Vertex> path = new List<Vertex> { destination };
            Vertex currentVertex = destination;

            DijkstraValues[InitialVertex].UpdatedBy = InitialVertex;
            
            while (currentVertex.ID != InitialVertex.ID)
            {
                currentVertex = GetPrevious(currentVertex);
                path.Add(currentVertex);
            }

            path.Reverse();

            return path;
        }

        private Vertex GetPrevious(Vertex vertex)
        {
            return DijkstraValues[vertex].UpdatedBy;
        }

        private void ClearPreviousData()
        {
            this.Selections.Clear();
            this.DijkstraValues.Clear();
        }

        public void UpdateInitialVertex(Vertex newInitialVertex)
        {
            this.InitialVertex = newInitialVertex;
        }

        public bool IsConnectedGraph(Vertex destinationVertex)
        {
            return DijkstraValues[destinationVertex].Weight != ToolFunction.INFINITE;
        }
    }

    public class DijkstraValue
    {
        public double Weight { set; get; }
        public bool IsDefinitive { set; get; }
        public Vertex Vertex { set; get; }

        public Vertex UpdatedBy { set; get; }

        public DijkstraValue
        (double weight, bool isDefinitive, Vertex vertex)
        {
            this.Weight = weight;
            this.IsDefinitive = isDefinitive;
            this.Vertex = vertex;
        }
    }
}
