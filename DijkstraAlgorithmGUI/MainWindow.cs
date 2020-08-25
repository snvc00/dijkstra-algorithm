using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace SEMALG_actividad04
{
    public partial class MainWindow : Form
    {
        Bitmap GraphBitmap;
        Graph Graph;
        string ImagePath;
        Bitmap CurrentParticle;
        bool ImageLoaded, GraphCreated, DijkstraExecuted;
        Vertex InitialVertex;
        Vertex DestinationVertex;
        List<Vertex> AnimationSequence;
        Dijkstra DijkstraInstance;

        public MainWindow()
        {
            InitializeComponent();
            PictureBox_Graph.AllowDrop = true;
            PictureBox_Particle1.AllowDrop = true;
        }

        private void SetInitialStatus()
        {
            this.ImageLoaded = false;
            this.GraphCreated = false;
            this.DijkstraExecuted = false;
        }

        private void Button_Load_Click(object sender, EventArgs e)
        {
            try
            {
                SetInitialStatus();
                Button_Reset_Click(sender, e);

                OpenExplorer.ShowDialog();
                this.ImagePath = OpenExplorer.FileName;
                PictureBox_Graph.Image = new Bitmap(ImagePath);
                PictureBox_Graph.Refresh();
                this.ImageLoaded = true;
            }
            catch
            {
                Notification message = new Notification("Error al intentar abrir archivo.");
                message.ShowDialog();
            }
        }

        private void Button_Graph_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ImageLoaded)
                {
                    Notification message = new Notification("Es necesario cargar una imagen primero.");
                    message.ShowDialog();
                    return;
                }

                ImageProcessing processing = new ImageProcessing(ImagePath);
                processing.ProcessImage();

                if (processing.Status)
                {
                    this.GraphBitmap = new Bitmap(processing.GraphImage);
                    this.Graph = processing.Graph;

                    PictureBox_Graph.Image = this.GraphBitmap;
                    PictureBox_Graph.Refresh();

                    Notification message = new Notification(processing.Message);
                    message.ShowDialog();

                    this.GraphCreated = true;
                }
                else
                {
                    Notification message = new Notification(processing.Message);
                    message.ShowDialog();
                }
            }
            catch
            {
                Notification message = new Notification("Error al intentar procesar la imagen.");
                message.ShowDialog();
            }
        }

        private void Button_Dijkstra_Click(object sender, EventArgs e)
        {
            try
            {
                if (!GraphCreated)
                {
                    Notification message = new Notification("No olvides crear un grafo primero.");
                    message.ShowDialog();
                    return;
                }

                Notification message1 = new Notification("Elige un punto de inicio");
                message1.ShowDialog();

                Label_Start.Location = new Point((ComboBox_Vertices.Location.X + (ComboBox_Vertices.Width / 2)) - (Label_Start.Width / 2), Label_Start.Location.Y);
                Label_Start.Visible = true;
                ComboBox_Vertices.DataSource = Graph.VertexList;
                ComboBox_Vertices.Visible = true;
                Button_Next.Visible = true;
                Button_Reset.Visible = true;
            }
            catch
            {
                Notification message = new Notification("Error al ejecutar el algoritmo de Dijkstra.");
                message.ShowDialog();
            }
        }

        private void Button_Animate_Click(object sender, EventArgs e)
        {
            try
            {
                if (!DijkstraExecuted)
                {
                    Notification message1 = new Notification("Para generar una animación es necesario ejecutar Dijkstra.");
                    message1.ShowDialog();
                    return;
                }

                if (InitialVertex == null)
                {
                    Notification message2 = new Notification("Definir primero el punto inicial.");
                    message2.ShowDialog();
                    return;
                }

                if (DestinationVertex == null)
                {
                    Notification message3 = new Notification("Definir primero el destino.");
                    message3.ShowDialog();
                    return;
                }

                if (CurrentParticle != null)
                    if (AnimationSequence != null)
                        ShowAnimation();

                Notification message = new Notification("Animación completada.");

                if (CurrentParticle != null)
                    message.ShowDialog();
            }
            catch
            {
                Notification message = new Notification("Error al intentar recrear la animación.");
                message.ShowDialog();
            }
        }

        private void ShowAnimation()
        {
            Bitmap original = new Bitmap(PictureBox_Graph.Image);
            Bitmap background = new Bitmap(PictureBox_Graph.Image);
            Bitmap temporal = new Bitmap(PictureBox_Graph.Image);
            Bitmap animationParticle = new Bitmap(CurrentParticle, new Size((int)(CurrentParticle.Width * 0.1), (int)(CurrentParticle.Height * 0.1)));
            
            int xCorrection = animationParticle.Width / 2, yCorrection = animationParticle.Height / 2;
            List<Point> points;

            for (int i = 0; i < AnimationSequence.Count - 1; ++i)
            {
                points = GetPoints(AnimationSequence[i], AnimationSequence[i + 1]);
                Graphics.FromImage(background).DrawLine(new Pen(Color.FromArgb(54, 54, 54), 3), AnimationSequence[i].GetCirclePoint(), AnimationSequence[i + 1].GetCirclePoint());
                
                for (int j = 0; j < points.Count; ++j)
                {
                    Graphics.FromImage(temporal).DrawImage(animationParticle, new Point(points[j].X - xCorrection, points[j].Y - yCorrection));
                    PictureBox_Graph.Image = temporal;
                    PictureBox_Graph.Refresh();
                    temporal = new Bitmap(background);
                    PictureBox_Graph.Image = background;
                }
            }

            PictureBox_Graph.Image = background;
            PictureBox_Graph.Refresh();
        }

        private List<Point> GetPoints(Vertex origin, Vertex destination)
        {
            List<Point> path = new List<Point>();

            foreach (Edge edge in origin.GetEdges())
            {
                if (edge.Destination.ID == destination.ID)
                {
                    path.Add(edge.Path[0]);

                    for (int i = 0; i < edge.Path.Count; i += 5)
                    {
                        path.Add(edge.Path[i]);
                    }

                    path.Add(edge.Path.Last());
                }
            }

            return path;
        }

        private void Button_About_Click(object sender, EventArgs e)
        {
            try
            {
                Notification message = new Notification("Para obtener información del uso de la aplicación:", true);
                message.ShowDialog();
            }
            catch
            {
                Notification message = new Notification("Error al intentar abrir la documentación.");
                message.ShowDialog();
            }
        }
        private void PictureBox_Particle1_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, PictureBox_Particle1.ClientRectangle, Color.FromArgb(54, 54, 54), ButtonBorderStyle.Dotted);
        }

        private void PictureBox_Particle2_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, PictureBox_Particle2.ClientRectangle, Color.FromArgb(54, 54, 54), ButtonBorderStyle.Dotted);

        }

        private void PictureBox_Particle3_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, PictureBox_Particle3.ClientRectangle, Color.FromArgb(54, 54, 54), ButtonBorderStyle.Dotted);
        }

        private void PictureBox_Graph_DragDrop(object sender, DragEventArgs e)
        {
            this.CurrentParticle = (Bitmap)e.Data.GetData(DataFormats.Bitmap, true);

            Notification message = new Notification("Particula seleccionada, ahora puedes animarla.");
            message.ShowDialog();
        }

        private void PictureBox_Graph_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Bitmap) && (e.AllowedEffect & DragDropEffects.Copy) != 0)
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;

        }

        private void PictureBox_Particle1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                PictureBox_Particle1.DoDragDrop(PictureBox_Particle1.Image, DragDropEffects.Copy);
        }

        private void Button_Next_Click(object sender, EventArgs e)
        {
            try
            {
                if (!DijkstraExecuted)
                {
                    this.InitialVertex = (Vertex)ComboBox_Vertices.SelectedItem;

                    Dijkstra dijkstra = new Dijkstra(this.Graph, this.InitialVertex);
                    dijkstra.DijkstraAlgorithm();
                    this.DijkstraInstance = dijkstra;

                    Notification message = new Notification("Dijkstra ejecutado correctamente, ahora elige tu destino.");
                    message.ShowDialog();

                    this.DijkstraExecuted = true;
                    Label_Start.Text = "Destino";
                    Label_Start.Location = new Point((ComboBox_Vertices.Location.X + (ComboBox_Vertices.Width / 2)) - (Label_Start.Width / 2), Label_Start.Location.Y);
                }
                else 
                {
                    this.DestinationVertex = (Vertex)ComboBox_Vertices.SelectedItem;
                    PictureBox_Graph.Image = this.GraphBitmap;

                    bool isConnected = DijkstraInstance.IsConnectedGraph(DestinationVertex);

                    if (this.DestinationVertex == this.InitialVertex)
                        isConnected = false;

                    Notification msg = new Notification("Este destino no es alcanzable o es igual al inicio, elige otro.");

                    if (!isConnected)
                    {
                        this.DestinationVertex = null;
                        msg.ShowDialog();
                        return;
                    }

                    AnimationSequence = DijkstraInstance.BuildPath(this.DestinationVertex);
                    this.Graph.CheckEdgePoints();

                    InitialVertex = DestinationVertex;
                    DijkstraInstance.UpdateInitialVertex(InitialVertex);
                    DijkstraInstance.DijkstraAlgorithm();

                    Notification message = new Notification("Arrastra una imagen para seleccionarla como particula.");

                    if (CurrentParticle == null)
                    {
                        message.ShowDialog();

                        PictureBox_Particle1.Visible = true;
                        PictureBox_Particle2.Visible = true;
                        PictureBox_Particle3.Visible = true;
                    }
                }
            }
            catch
            {
                Notification message = new Notification("Error en la ejecución del algoritmo de Dijkstra.");
                message.ShowDialog();
            }
        }

        private void PictureBox_Particle2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                PictureBox_Particle2.DoDragDrop(PictureBox_Particle2.Image, DragDropEffects.Copy);
        }

        private void Button_Reset_Click(object sender, EventArgs e)
        {
            RestartAnimationPanel();

            DijkstraExecuted = false;
            DijkstraInstance = null;
            AnimationSequence = null;
            CurrentParticle = null;
            InitialVertex = null;
            DestinationVertex = null;
        }

        private void PictureBox_Particle3_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                PictureBox_Particle3.DoDragDrop(PictureBox_Particle3.Image, DragDropEffects.Copy);
        }

        private void RestartAnimationPanel()
        {
            PictureBox_Particle1.Visible = false;
            PictureBox_Particle2.Visible = false;
            PictureBox_Particle3.Visible = false;

            Label_Start.Text = "Punto Inicial";
            Label_Start.Visible = false;
            ComboBox_Vertices.Visible = false;
            Button_Next.Visible = false;
            Button_Reset.Visible = false;
        }
    }
}
