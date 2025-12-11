namespace JawBreaker_
{
    partial class Estadisticas
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
            this.lsActual = new System.Windows.Forms.ListBox();
            this.lsHistorico = new System.Windows.Forms.ListBox();
            this.lblHistorico = new System.Windows.Forms.Label();
            this.lblPartidaActual = new System.Windows.Forms.Label();
            this.btnAñadir = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lsActual
            // 
            this.lsActual.FormattingEnabled = true;
            this.lsActual.ItemHeight = 16;
            this.lsActual.Location = new System.Drawing.Point(79, 70);
            this.lsActual.Name = "lsActual";
            this.lsActual.Size = new System.Drawing.Size(249, 228);
            this.lsActual.TabIndex = 0;
            // 
            // lsHistorico
            // 
            this.lsHistorico.FormattingEnabled = true;
            this.lsHistorico.ItemHeight = 16;
            this.lsHistorico.Location = new System.Drawing.Point(449, 70);
            this.lsHistorico.Name = "lsHistorico";
            this.lsHistorico.Size = new System.Drawing.Size(249, 228);
            this.lsHistorico.TabIndex = 1;
            // 
            // lblHistorico
            // 
            this.lblHistorico.AutoSize = true;
            this.lblHistorico.BackColor = System.Drawing.Color.Black;
            this.lblHistorico.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHistorico.ForeColor = System.Drawing.Color.White;
            this.lblHistorico.Location = new System.Drawing.Point(506, 48);
            this.lblHistorico.Name = "lblHistorico";
            this.lblHistorico.Size = new System.Drawing.Size(132, 16);
            this.lblHistorico.TabIndex = 2;
            this.lblHistorico.Text = "Registro Historico";
            // 
            // lblPartidaActual
            // 
            this.lblPartidaActual.AutoSize = true;
            this.lblPartidaActual.BackColor = System.Drawing.Color.Black;
            this.lblPartidaActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPartidaActual.ForeColor = System.Drawing.Color.White;
            this.lblPartidaActual.Location = new System.Drawing.Point(126, 48);
            this.lblPartidaActual.Name = "lblPartidaActual";
            this.lblPartidaActual.Size = new System.Drawing.Size(129, 16);
            this.lblPartidaActual.TabIndex = 3;
            this.lblPartidaActual.Text = "Partidas Actuales";
            // 
            // btnAñadir
            // 
            this.btnAñadir.BackColor = System.Drawing.Color.Black;
            this.btnAñadir.Enabled = false;
            this.btnAñadir.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAñadir.ForeColor = System.Drawing.Color.White;
            this.btnAñadir.Location = new System.Drawing.Point(103, 339);
            this.btnAñadir.Name = "btnAñadir";
            this.btnAñadir.Size = new System.Drawing.Size(183, 50);
            this.btnAñadir.TabIndex = 4;
            this.btnAñadir.Text = "Añadir!";
            this.btnAñadir.UseVisualStyleBackColor = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Black;
            this.btnEliminar.Enabled = false;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(481, 339);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(183, 50);
            this.btnEliminar.TabIndex = 5;
            this.btnEliminar.Text = "Eliminar!";
            this.btnEliminar.UseVisualStyleBackColor = false;
            // 
            // Estadisticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::JawBreaker_.Properties.Resources.patasGato;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAñadir);
            this.Controls.Add(this.lblPartidaActual);
            this.Controls.Add(this.lblHistorico);
            this.Controls.Add(this.lsHistorico);
            this.Controls.Add(this.lsActual);
            this.Name = "Estadisticas";
            this.Text = "Estadisticas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ListBox lsActual;
        public System.Windows.Forms.ListBox lsHistorico;
        public System.Windows.Forms.Label lblHistorico;
        public System.Windows.Forms.Label lblPartidaActual;
        public System.Windows.Forms.Button btnAñadir;
        public System.Windows.Forms.Button btnEliminar;
    }
}