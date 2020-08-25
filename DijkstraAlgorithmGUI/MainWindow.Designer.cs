namespace SEMALG_actividad04
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Panel Panel_ActionButtons;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.Button_About = new System.Windows.Forms.Button();
            this.Button_Animate = new System.Windows.Forms.Button();
            this.Button_Dijkstra = new System.Windows.Forms.Button();
            this.Button_Load = new System.Windows.Forms.Button();
            this.Button_Graph = new System.Windows.Forms.Button();
            this.OpenExplorer = new System.Windows.Forms.OpenFileDialog();
            this.Label_Start = new System.Windows.Forms.Label();
            this.ComboBox_Vertices = new System.Windows.Forms.ComboBox();
            this.Button_Reset = new System.Windows.Forms.Button();
            this.Button_Next = new System.Windows.Forms.Button();
            this.PictureBox_Particle3 = new System.Windows.Forms.PictureBox();
            this.PictureBox_Particle2 = new System.Windows.Forms.PictureBox();
            this.PictureBox_Particle1 = new System.Windows.Forms.PictureBox();
            this.PictureBox_Graph = new System.Windows.Forms.PictureBox();
            Panel_ActionButtons = new System.Windows.Forms.Panel();
            Panel_ActionButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Particle3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Particle2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Particle1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Graph)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel_ActionButtons
            // 
            Panel_ActionButtons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            Panel_ActionButtons.Controls.Add(this.Button_About);
            Panel_ActionButtons.Controls.Add(this.Button_Animate);
            Panel_ActionButtons.Controls.Add(this.Button_Dijkstra);
            Panel_ActionButtons.Controls.Add(this.Button_Load);
            Panel_ActionButtons.Controls.Add(this.Button_Graph);
            Panel_ActionButtons.Location = new System.Drawing.Point(-3, 608);
            Panel_ActionButtons.Name = "Panel_ActionButtons";
            Panel_ActionButtons.Size = new System.Drawing.Size(1292, 126);
            Panel_ActionButtons.TabIndex = 0;
            // 
            // Button_About
            // 
            this.Button_About.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.Button_About.FlatAppearance.BorderSize = 0;
            this.Button_About.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_About.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_About.ForeColor = System.Drawing.SystemColors.Control;
            this.Button_About.Image = ((System.Drawing.Image)(resources.GetObject("Button_About.Image")));
            this.Button_About.Location = new System.Drawing.Point(1115, 0);
            this.Button_About.Name = "Button_About";
            this.Button_About.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.Button_About.Size = new System.Drawing.Size(168, 130);
            this.Button_About.TabIndex = 4;
            this.Button_About.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Button_About.UseVisualStyleBackColor = false;
            this.Button_About.Click += new System.EventHandler(this.Button_About_Click);
            // 
            // Button_Animate
            // 
            this.Button_Animate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.Button_Animate.FlatAppearance.BorderSize = 0;
            this.Button_Animate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Animate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Animate.ForeColor = System.Drawing.SystemColors.Control;
            this.Button_Animate.Image = ((System.Drawing.Image)(resources.GetObject("Button_Animate.Image")));
            this.Button_Animate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Button_Animate.Location = new System.Drawing.Point(729, 0);
            this.Button_Animate.Name = "Button_Animate";
            this.Button_Animate.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.Button_Animate.Size = new System.Drawing.Size(242, 130);
            this.Button_Animate.TabIndex = 3;
            this.Button_Animate.Text = "Animación";
            this.Button_Animate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Button_Animate.UseVisualStyleBackColor = false;
            this.Button_Animate.Click += new System.EventHandler(this.Button_Animate_Click);
            // 
            // Button_Dijkstra
            // 
            this.Button_Dijkstra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.Button_Dijkstra.FlatAppearance.BorderSize = 0;
            this.Button_Dijkstra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Dijkstra.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Dijkstra.ForeColor = System.Drawing.SystemColors.Control;
            this.Button_Dijkstra.Image = ((System.Drawing.Image)(resources.GetObject("Button_Dijkstra.Image")));
            this.Button_Dijkstra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Button_Dijkstra.Location = new System.Drawing.Point(486, 0);
            this.Button_Dijkstra.Name = "Button_Dijkstra";
            this.Button_Dijkstra.Padding = new System.Windows.Forms.Padding(15, 0, 30, 0);
            this.Button_Dijkstra.Size = new System.Drawing.Size(242, 130);
            this.Button_Dijkstra.TabIndex = 2;
            this.Button_Dijkstra.Text = "Dijkstra";
            this.Button_Dijkstra.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Button_Dijkstra.UseVisualStyleBackColor = false;
            this.Button_Dijkstra.Click += new System.EventHandler(this.Button_Dijkstra_Click);
            // 
            // Button_Load
            // 
            this.Button_Load.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.Button_Load.FlatAppearance.BorderSize = 0;
            this.Button_Load.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Load.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Load.ForeColor = System.Drawing.SystemColors.Control;
            this.Button_Load.Image = ((System.Drawing.Image)(resources.GetObject("Button_Load.Image")));
            this.Button_Load.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Button_Load.Location = new System.Drawing.Point(0, 0);
            this.Button_Load.Name = "Button_Load";
            this.Button_Load.Padding = new System.Windows.Forms.Padding(15, 0, 40, 0);
            this.Button_Load.Size = new System.Drawing.Size(242, 130);
            this.Button_Load.TabIndex = 1;
            this.Button_Load.Text = "Cargar";
            this.Button_Load.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Button_Load.UseVisualStyleBackColor = false;
            this.Button_Load.Click += new System.EventHandler(this.Button_Load_Click);
            // 
            // Button_Graph
            // 
            this.Button_Graph.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.Button_Graph.FlatAppearance.BorderSize = 0;
            this.Button_Graph.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Graph.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Graph.ForeColor = System.Drawing.SystemColors.Control;
            this.Button_Graph.Image = ((System.Drawing.Image)(resources.GetObject("Button_Graph.Image")));
            this.Button_Graph.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Button_Graph.Location = new System.Drawing.Point(243, 0);
            this.Button_Graph.Name = "Button_Graph";
            this.Button_Graph.Padding = new System.Windows.Forms.Padding(15, 0, 40, 0);
            this.Button_Graph.Size = new System.Drawing.Size(242, 130);
            this.Button_Graph.TabIndex = 0;
            this.Button_Graph.Text = "Crear\r\nGrafo";
            this.Button_Graph.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Button_Graph.UseVisualStyleBackColor = false;
            this.Button_Graph.Click += new System.EventHandler(this.Button_Graph_Click);
            // 
            // OpenExplorer
            // 
            this.OpenExplorer.FileName = "openFileDialog1";
            // 
            // Label_Start
            // 
            this.Label_Start.AutoSize = true;
            this.Label_Start.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Start.Location = new System.Drawing.Point(1099, 396);
            this.Label_Start.Name = "Label_Start";
            this.Label_Start.Size = new System.Drawing.Size(95, 20);
            this.Label_Start.TabIndex = 6;
            this.Label_Start.Text = "Punto Inicial";
            this.Label_Start.Visible = false;
            // 
            // ComboBox_Vertices
            // 
            this.ComboBox_Vertices.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_Vertices.FormattingEnabled = true;
            this.ComboBox_Vertices.Location = new System.Drawing.Point(1103, 433);
            this.ComboBox_Vertices.Name = "ComboBox_Vertices";
            this.ComboBox_Vertices.Size = new System.Drawing.Size(111, 28);
            this.ComboBox_Vertices.TabIndex = 7;
            this.ComboBox_Vertices.Visible = false;
            // 
            // Button_Reset
            // 
            this.Button_Reset.BackColor = System.Drawing.Color.Transparent;
            this.Button_Reset.FlatAppearance.BorderSize = 0;
            this.Button_Reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Reset.Image = ((System.Drawing.Image)(resources.GetObject("Button_Reset.Image")));
            this.Button_Reset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Button_Reset.Location = new System.Drawing.Point(1052, 550);
            this.Button_Reset.Name = "Button_Reset";
            this.Button_Reset.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.Button_Reset.Size = new System.Drawing.Size(197, 41);
            this.Button_Reset.TabIndex = 9;
            this.Button_Reset.Text = "Reiniciar";
            this.Button_Reset.UseVisualStyleBackColor = false;
            this.Button_Reset.Visible = false;
            this.Button_Reset.Click += new System.EventHandler(this.Button_Reset_Click);
            // 
            // Button_Next
            // 
            this.Button_Next.BackColor = System.Drawing.Color.Transparent;
            this.Button_Next.FlatAppearance.BorderSize = 0;
            this.Button_Next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Next.Image = ((System.Drawing.Image)(resources.GetObject("Button_Next.Image")));
            this.Button_Next.Location = new System.Drawing.Point(1112, 471);
            this.Button_Next.Name = "Button_Next";
            this.Button_Next.Size = new System.Drawing.Size(86, 56);
            this.Button_Next.TabIndex = 8;
            this.Button_Next.Text = "\r\n";
            this.Button_Next.UseVisualStyleBackColor = false;
            this.Button_Next.Visible = false;
            this.Button_Next.Click += new System.EventHandler(this.Button_Next_Click);
            // 
            // PictureBox_Particle3
            // 
            this.PictureBox_Particle3.Image = global::SEMALG_actividad04.Properties.Resources.particle2;
            this.PictureBox_Particle3.InitialImage = ((System.Drawing.Image)(resources.GetObject("PictureBox_Particle3.InitialImage")));
            this.PictureBox_Particle3.Location = new System.Drawing.Point(1081, 260);
            this.PictureBox_Particle3.Name = "PictureBox_Particle3";
            this.PictureBox_Particle3.Size = new System.Drawing.Size(149, 116);
            this.PictureBox_Particle3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBox_Particle3.TabIndex = 5;
            this.PictureBox_Particle3.TabStop = false;
            this.PictureBox_Particle3.Visible = false;
            this.PictureBox_Particle3.Paint += new System.Windows.Forms.PaintEventHandler(this.PictureBox_Particle3_Paint);
            this.PictureBox_Particle3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PictureBox_Particle3_MouseDown);
            // 
            // PictureBox_Particle2
            // 
            this.PictureBox_Particle2.Image = global::SEMALG_actividad04.Properties.Resources.particle1;
            this.PictureBox_Particle2.InitialImage = ((System.Drawing.Image)(resources.GetObject("PictureBox_Particle2.InitialImage")));
            this.PictureBox_Particle2.Location = new System.Drawing.Point(1081, 135);
            this.PictureBox_Particle2.Name = "PictureBox_Particle2";
            this.PictureBox_Particle2.Size = new System.Drawing.Size(149, 116);
            this.PictureBox_Particle2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBox_Particle2.TabIndex = 4;
            this.PictureBox_Particle2.TabStop = false;
            this.PictureBox_Particle2.Visible = false;
            this.PictureBox_Particle2.Paint += new System.Windows.Forms.PaintEventHandler(this.PictureBox_Particle2_Paint);
            this.PictureBox_Particle2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PictureBox_Particle2_MouseDown);
            // 
            // PictureBox_Particle1
            // 
            this.PictureBox_Particle1.Image = global::SEMALG_actividad04.Properties.Resources.particle0;
            this.PictureBox_Particle1.InitialImage = ((System.Drawing.Image)(resources.GetObject("PictureBox_Particle1.InitialImage")));
            this.PictureBox_Particle1.Location = new System.Drawing.Point(1081, 11);
            this.PictureBox_Particle1.Name = "PictureBox_Particle1";
            this.PictureBox_Particle1.Size = new System.Drawing.Size(149, 116);
            this.PictureBox_Particle1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBox_Particle1.TabIndex = 3;
            this.PictureBox_Particle1.TabStop = false;
            this.PictureBox_Particle1.Visible = false;
            this.PictureBox_Particle1.Paint += new System.Windows.Forms.PaintEventHandler(this.PictureBox_Particle1_Paint);
            this.PictureBox_Particle1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PictureBox_Particle1_MouseDown);
            // 
            // PictureBox_Graph
            // 
            this.PictureBox_Graph.Location = new System.Drawing.Point(18, 1);
            this.PictureBox_Graph.Name = "PictureBox_Graph";
            this.PictureBox_Graph.Size = new System.Drawing.Size(997, 607);
            this.PictureBox_Graph.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBox_Graph.TabIndex = 2;
            this.PictureBox_Graph.TabStop = false;
            this.PictureBox_Graph.DragDrop += new System.Windows.Forms.DragEventHandler(this.PictureBox_Graph_DragDrop);
            this.PictureBox_Graph.DragEnter += new System.Windows.Forms.DragEventHandler(this.PictureBox_Graph_DragEnter);
            // 
            // MainWindow
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1282, 734);
            this.Controls.Add(this.Button_Reset);
            this.Controls.Add(this.Button_Next);
            this.Controls.Add(this.ComboBox_Vertices);
            this.Controls.Add(this.Label_Start);
            this.Controls.Add(this.PictureBox_Particle3);
            this.Controls.Add(this.PictureBox_Particle2);
            this.Controls.Add(this.PictureBox_Particle1);
            this.Controls.Add(this.PictureBox_Graph);
            this.Controls.Add(Panel_ActionButtons);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Actividad 04 - Algoritmo de Dijkstra";
            Panel_ActionButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Particle3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Particle2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Particle1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Graph)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Button_Graph;
        private System.Windows.Forms.Button Button_Animate;
        private System.Windows.Forms.Button Button_Dijkstra;
        private System.Windows.Forms.Button Button_Load;
        private System.Windows.Forms.Button Button_About;
        private System.Windows.Forms.PictureBox PictureBox_Graph;
        private System.Windows.Forms.OpenFileDialog OpenExplorer;
        private System.Windows.Forms.PictureBox PictureBox_Particle1;
        private System.Windows.Forms.PictureBox PictureBox_Particle2;
        private System.Windows.Forms.PictureBox PictureBox_Particle3;
        private System.Windows.Forms.Label Label_Start;
        private System.Windows.Forms.ComboBox ComboBox_Vertices;
        private System.Windows.Forms.Button Button_Next;
        private System.Windows.Forms.Button Button_Reset;
    }
}

