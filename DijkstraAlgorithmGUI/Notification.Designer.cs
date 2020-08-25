namespace SEMALG_actividad04
{
    partial class Notification
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Notification));
            this.Button_Ok = new System.Windows.Forms.Button();
            this.Label_Message = new System.Windows.Forms.Label();
            this.LinkLabel_Documentation = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // Button_Ok
            // 
            this.Button_Ok.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.Button_Ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Ok.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.Button_Ok.Image = ((System.Drawing.Image)(resources.GetObject("Button_Ok.Image")));
            this.Button_Ok.Location = new System.Drawing.Point(-1, 199);
            this.Button_Ok.Name = "Button_Ok";
            this.Button_Ok.Size = new System.Drawing.Size(721, 115);
            this.Button_Ok.TabIndex = 0;
            this.Button_Ok.UseVisualStyleBackColor = false;
            this.Button_Ok.Click += new System.EventHandler(this.Button_Ok_Click);
            // 
            // Label_Message
            // 
            this.Label_Message.AutoSize = true;
            this.Label_Message.Font = new System.Drawing.Font("Roboto Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Message.Location = new System.Drawing.Point(266, 85);
            this.Label_Message.Name = "Label_Message";
            this.Label_Message.Size = new System.Drawing.Size(108, 29);
            this.Label_Message.TabIndex = 1;
            this.Label_Message.Text = "Message";
            this.Label_Message.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LinkLabel_Documentation
            // 
            this.LinkLabel_Documentation.ActiveLinkColor = System.Drawing.Color.DarkBlue;
            this.LinkLabel_Documentation.AutoSize = true;
            this.LinkLabel_Documentation.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LinkLabel_Documentation.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(232)))));
            this.LinkLabel_Documentation.Location = new System.Drawing.Point(245, 129);
            this.LinkLabel_Documentation.Name = "LinkLabel_Documentation";
            this.LinkLabel_Documentation.Size = new System.Drawing.Size(236, 24);
            this.LinkLabel_Documentation.TabIndex = 2;
            this.LinkLabel_Documentation.TabStop = true;
            this.LinkLabel_Documentation.Text = "Consultar Documentación";
            this.LinkLabel_Documentation.Visible = false;
            this.LinkLabel_Documentation.VisitedLinkColor = System.Drawing.Color.MidnightBlue;
            this.LinkLabel_Documentation.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel_Documentation_LinkClicked);
            // 
            // Notification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(720, 309);
            this.Controls.Add(this.LinkLabel_Documentation);
            this.Controls.Add(this.Label_Message);
            this.Controls.Add(this.Button_Ok);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Notification";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Actividad 04 - Notificación";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Button_Ok;
        private System.Windows.Forms.Label Label_Message;
        private System.Windows.Forms.LinkLabel LinkLabel_Documentation;
    }
}