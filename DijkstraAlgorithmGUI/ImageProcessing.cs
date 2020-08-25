using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace SEMALG_actividad04
{
    public class ImageProcessing
    {
        Bitmap IBmp;
        List<Circle> ICircleList;
        Graph IGraph;
        bool IStatus;
        string IMessage;
        List<Point> Coords;

        public ImageProcessing(string _filePath)
        {
            try
            {
                this.IBmp = new Bitmap(_filePath);
                this.ICircleList = new List<Circle>();
                this.IStatus = true;
                this.IMessage = "";
            }
            catch
            {
                this.IMessage = "Error al abrir el archivo";
                this.IStatus = false;
            }
        }

        public void ProcessImage()
        {
            if (IStatus != false)
            {
                CirclesRecognition();
                CreateGraph();
            }
        }

        private void CreateGraph()
        {
            if (ICircleList.Count > 0)
            {
                this.IGraph = new Graph();
                ICircleList = SortedCircleList();

                foreach (Circle circle in ICircleList)
                    IGraph.AddVertex(new Vertex(circle, IGraph.GetVertexCount() + 1));

                for (int i = 0; i < ICircleList.Count - 1; ++i)
                {
                    for (int j = i + 1; j < ICircleList.Count; ++j)
                    {
                        if (IsObstacleFree(IGraph[i].Circle, IGraph[j].Circle))
                        {
                            double distance = ToolFunction.Distance(IGraph[j].GetCirclePoint(), IGraph[i].GetCirclePoint());

                            IGraph[i].AddEdge(new Edge(distance, IGraph[j], new List<Point>(this.Coords)));

                            this.Coords.Reverse();

                            IGraph[j].AddEdge(new Edge(distance, IGraph[i], new List<Point>(this.Coords)));

                            Coords.Clear();
                        }
                    }
                }

                ModifyBitmapFromGraph();

                this.IMessage = "Grafo creado exitosamente.";
            }
            else
            {
                this.IMessage = "No existen elementos para crear un grafo.";
                this.IStatus = false;
            }
        }

        private void ModifyBitmapFromGraph()
        {
            for (int i = 0; i < IGraph.GetVertexCount() - 1; ++i)
            {
                for (int j = 0; j < IGraph[i].GetEdgesListCount(); ++j)
                    Graphics.FromImage(IBmp).DrawLine(new Pen(Color.FromArgb(0, 178, 232), 2), IGraph[i].GetCirclePoint(), IGraph[i][j].Destination.GetCirclePoint());
            }

            Font font = new Font("Roboto", CalculateFontSize(), FontStyle.Regular);
            StringFormat strformat = new StringFormat
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };

            foreach (Vertex v in IGraph.VertexList)
                Graphics.FromImage(IBmp).DrawString(v.ID.ToString(), font, new SolidBrush(Color.FromArgb(0, 233, 212)), v.GetCirclePoint().X, v.GetCirclePoint().Y, strformat);
        }

        private int CalculateFontSize()
        {
            double value = 0;

            foreach (Circle c in ICircleList)
                value += c.Radius;

            return Convert.ToInt32(value / ICircleList.Count);
        }

        private void CirclesRecognition()
        {
            int height, width;

            for (int y = 0; y < IBmp.Height; ++y)
            {
                for (int x = 0; x < IBmp.Width; ++x)
                {
                    if (IBmp.GetPixel(x, y).R == 0 &&
                        IBmp.GetPixel(x, y).G == 0 &&
                        IBmp.GetPixel(x, y).B == 0)
                    {
                        for (int y_down = y; y_down < IBmp.Height; ++y_down)
                        {
                            if ((IBmp.GetPixel(x, y_down).R != 0 &&
                                IBmp.GetPixel(x, y_down).G != 0 &&
                                IBmp.GetPixel(x, y_down).B != 0) ||
                                y_down == IBmp.Height - 1)
                            {
                                height = (y_down - 1) - y;

                                for (int x_left = x; x_left >= 0; --x_left)
                                {
                                    if ((IBmp.GetPixel(x_left, y + height / 2).R != 0 &&
                                        IBmp.GetPixel(x_left, y + height / 2).G != 0 &&
                                        IBmp.GetPixel(x_left, y + height / 2).B != 0) ||
                                        x_left == 0)
                                    {
                                        for (int x_right = x_left + 1; x_right < IBmp.Width; ++x_right)
                                        {
                                            if ((IBmp.GetPixel(x_right, y + height / 2).R != 0 &&
                                                IBmp.GetPixel(x_right, y + height / 2).G != 0 &&
                                                IBmp.GetPixel(x_right, y + height / 2).B != 0) ||
                                                x_right == IBmp.Width - 1)
                                            {
                                                width = (x_right - 1) - x_left;

                                                if (Math.Abs(width - height) <= 10)
                                                {
                                                    ICircleList.Add(new Circle((x_left + width / 2), (y + height / 2), (height / 2)));

                                                    if (height < width)
                                                        DrawEllipse((x_left + width / 2), (y + height / 2), width + 2, width + 2, Color.FromArgb(1, 1, 1));
                                                    else
                                                        DrawEllipse((x_left + width / 2), (y + height / 2), height + 2, height + 2, Color.FromArgb(1, 1, 1));

                                                    DrawEllipse((x_left + width / 2), (y + height / 2), 5, 5, Color.Red);
                                                }
                                                else
                                                {
                                                    DrawEllipse((x_left + width / 2), (y + height / 2), width + 5, height + 5, Color.White);
                                                }
                                                break;
                                            }
                                        }
                                        break;
                                    }
                                }
                                break;
                            }
                        }
                    }
                }
            }
        }

        public bool IsObstacleFree(Circle A, Circle B)
        {
            float b, m;
            bool IsObstacleFree = false, isConstant = false;
            PointF origin, destination;
            List<Point> temporalPoints = new List<Point>();


            origin = new PointF((float)A.X, (float)A.Y);
            destination = new PointF((float)B.X, (float)B.Y);

            if (origin.X - destination.X == 0)
            {
                m = 1.001f;
                b = origin.Y - origin.X;
                isConstant = true;
            }
            else if (origin.Y - destination.Y == 0)
            {
                m = 1;
                b = origin.Y - origin.X;
                isConstant = true;
            }
            else
            {
                m = (destination.Y - origin.Y) / (destination.X - origin.X);
                b = origin.Y - m * origin.X;
            }

            // Draw
            DrawEllipse(A.X, A.Y, A.Radius * 2 + 8, A.Radius * 2 + 8, Color.FromArgb(255, 255, 255));
            DrawEllipse(B.X, B.Y, B.Radius * 2 + 8, B.Radius * 2 + 8, Color.FromArgb(255, 255, 255));

            if (m <= 1 && m > -1)
            {
                for (float x_i = origin.X, y_i; x_i <= destination.X; ++x_i)
                {
                    if (isConstant)
                        y_i = origin.X + b;
                    else
                        y_i = m * x_i + b;

                    temporalPoints.Add(new Point((int)Math.Round(x_i), (int)Math.Round(y_i)));

                    if (!IsWhitePixel((int)x_i, (int)y_i))
                    {
                        IsObstacleFree = false;
                        break;
                    }

                    if (x_i == destination.X - 1)
                    {
                        IsObstacleFree = true;
                        Coords = new List<Point>(temporalPoints);
                        break;
                    }
                }
            }
            else
            {
                if (A.X < B.X && A.Y > B.Y)
                {
                    origin = new PointF((float)B.X, (float)B.Y);
                    destination = new PointF((float)A.X, (float)A.Y);
                }

                for (float y_i = origin.Y, x_i; y_i <= destination.Y; ++y_i)
                {
                    if (isConstant)
                        x_i = origin.Y - b;
                    else
                        x_i = (y_i - b) / m;

                    temporalPoints.Add(new Point((int)Math.Round(x_i), (int)Math.Round(y_i)));

                    if (!IsWhitePixel((int)x_i, (int)y_i))
                    {
                        IsObstacleFree = false;
                        break;
                    }

                    if (y_i == destination.Y - 1)
                    {
                        IsObstacleFree = true;
                        Coords = temporalPoints.ToList();
                        break;
                    }
                }
            }

            // Draw
            DrawEllipse(A.X, A.Y, A.Radius * 2 + 2, A.Radius * 2 + 2, Color.FromArgb(1, 1, 1));
            DrawEllipse(B.X, B.Y, B.Radius * 2 + 2, B.Radius * 2 + 2, Color.FromArgb(1, 1, 1));
            DrawEllipse(A.X, A.Y, 5, 5, Color.Red);
            DrawEllipse(B.X, B.Y, 5, 5, Color.Red);

            return IsObstacleFree;
        }

        private bool IsWhitePixel(int x, int y)
        {
            return IBmp.GetPixel(x, y).R == 255 && IBmp.GetPixel(x, y).G == 255 && IBmp.GetPixel(x, y).B == 255;
        }

        private void DrawEllipse(int x, int y, int width, int height, Color color)
        {
            Brush brush = new SolidBrush(color);
            Graphics.FromImage(IBmp).FillEllipse(brush, (x - width / 2) - 1, (y - height / 2) - 1, width + 2, height + 2);
        }
        private List<Circle> SortedCircleList()
        {
            return this.ICircleList.OrderBy(circle => circle.X).ToList();
        }

        public Graph Graph
        {
            get { return this.IGraph; }
        }

        public Bitmap GraphImage
        {
            get { return this.IBmp; }
        }

        public bool Status
        {
            get { return this.IStatus; }
        }

        public string Message
        {
            get { return this.IMessage; }
        }
    }
}
