namespace JawBreaker_
{
    partial class KitBreaker
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KitBreaker));
            this.pnJuego = new System.Windows.Forms.Panel();
            this.pnInfo = new System.Windows.Forms.Panel();
            this.lblContGatos = new System.Windows.Forms.Label();
            this.lblContPuntos = new System.Windows.Forms.Label();
            this.lblPuntosTotales = new System.Windows.Forms.Label();
            this.lblPartidas = new System.Windows.Forms.Label();
            this.lblPuntuacionMedia = new System.Windows.Forms.Label();
            this.lblMejorPuntuacion = new System.Windows.Forms.Label();
            this.tTip = new System.Windows.Forms.ToolTip(this.components);
            this.pbFondoJuego = new System.Windows.Forms.PictureBox();
            this.btnReiniciar = new System.Windows.Forms.Button();
            this.btnAyuda = new System.Windows.Forms.Button();
            this.btnStats = new System.Windows.Forms.Button();
            this.btnTitulo = new System.Windows.Forms.Button();
            this.btnJugar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbFondoJuego)).BeginInit();
            this.SuspendLayout();
            // 
            // pnJuego
            // 
            this.pnJuego.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnJuego.Location = new System.Drawing.Point(456, 55);
            this.pnJuego.Name = "pnJuego";
            this.pnJuego.Size = new System.Drawing.Size(695, 677);
            this.pnJuego.TabIndex = 1;
            // 
            // pnInfo
            // 
            this.pnInfo.Location = new System.Drawing.Point(20, 331);
            this.pnInfo.Name = "pnInfo";
            this.pnInfo.Size = new System.Drawing.Size(341, 114);
            this.pnInfo.TabIndex = 7;
            // 
            // lblContGatos
            // 
            this.lblContGatos.AutoSize = true;
            this.lblContGatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContGatos.ForeColor = System.Drawing.Color.White;
            this.lblContGatos.Location = new System.Drawing.Point(57, 483);
            this.lblContGatos.Name = "lblContGatos";
            this.lblContGatos.Size = new System.Drawing.Size(135, 16);
            this.lblContGatos.TabIndex = 8;
            this.lblContGatos.Text = "Contador Bloques:";
            this.tTip.SetToolTip(this.lblContGatos, "Total de bloques juntos en la seleccion");
            // 
            // lblContPuntos
            // 
            this.lblContPuntos.AutoSize = true;
            this.lblContPuntos.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContPuntos.ForeColor = System.Drawing.Color.White;
            this.lblContPuntos.Location = new System.Drawing.Point(57, 517);
            this.lblContPuntos.Name = "lblContPuntos";
            this.lblContPuntos.Size = new System.Drawing.Size(154, 16);
            this.lblContPuntos.TabIndex = 9;
            this.lblContPuntos.Text = "Contador Puntuacion:";
            this.tTip.SetToolTip(this.lblContPuntos, "Total de puntos por los bloques seleccionados");
            // 
            // lblPuntosTotales
            // 
            this.lblPuntosTotales.AutoSize = true;
            this.lblPuntosTotales.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuntosTotales.ForeColor = System.Drawing.Color.White;
            this.lblPuntosTotales.Location = new System.Drawing.Point(57, 553);
            this.lblPuntosTotales.Name = "lblPuntosTotales";
            this.lblPuntosTotales.Size = new System.Drawing.Size(127, 16);
            this.lblPuntosTotales.TabIndex = 10;
            this.lblPuntosTotales.Text = "Puntuacion Total:";
            // 
            // lblPartidas
            // 
            this.lblPartidas.AutoSize = true;
            this.lblPartidas.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPartidas.ForeColor = System.Drawing.Color.White;
            this.lblPartidas.Location = new System.Drawing.Point(58, 617);
            this.lblPartidas.Name = "lblPartidas";
            this.lblPartidas.Size = new System.Drawing.Size(133, 16);
            this.lblPartidas.TabIndex = 11;
            this.lblPartidas.Text = "Partidas Jugadas:";
            // 
            // lblPuntuacionMedia
            // 
            this.lblPuntuacionMedia.AutoSize = true;
            this.lblPuntuacionMedia.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuntuacionMedia.ForeColor = System.Drawing.Color.White;
            this.lblPuntuacionMedia.Location = new System.Drawing.Point(57, 653);
            this.lblPuntuacionMedia.Name = "lblPuntuacionMedia";
            this.lblPuntuacionMedia.Size = new System.Drawing.Size(134, 16);
            this.lblPuntuacionMedia.TabIndex = 12;
            this.lblPuntuacionMedia.Text = "Puntuacion Media:";
            // 
            // lblMejorPuntuacion
            // 
            this.lblMejorPuntuacion.AutoSize = true;
            this.lblMejorPuntuacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMejorPuntuacion.ForeColor = System.Drawing.Color.White;
            this.lblMejorPuntuacion.Location = new System.Drawing.Point(58, 692);
            this.lblMejorPuntuacion.Name = "lblMejorPuntuacion";
            this.lblMejorPuntuacion.Size = new System.Drawing.Size(130, 16);
            this.lblMejorPuntuacion.TabIndex = 13;
            this.lblMejorPuntuacion.Text = "Mejor Puntuacion:";
            // 
            // pbFondoJuego
            // 
            this.pbFondoJuego.BackgroundImage = global::JawBreaker_.Properties.Resources.pocoDetallado;
            this.pbFondoJuego.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbFondoJuego.Location = new System.Drawing.Point(387, 21);
            this.pbFondoJuego.Name = "pbFondoJuego";
            this.pbFondoJuego.Size = new System.Drawing.Size(837, 749);
            this.pbFondoJuego.TabIndex = 14;
            this.pbFondoJuego.TabStop = false;
            // 
            // btnReiniciar
            // 
            this.btnReiniciar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnReiniciar.BackgroundImage")));
            this.btnReiniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReiniciar.ForeColor = System.Drawing.Color.White;
            this.btnReiniciar.Location = new System.Drawing.Point(61, 174);
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.Size = new System.Drawing.Size(258, 39);
            this.btnReiniciar.TabIndex = 2;
            this.btnReiniciar.Text = "Reiniciar";
            this.tTip.SetToolTip(this.btnReiniciar, "Reiniciar la partida y sus puntos");
            this.btnReiniciar.UseVisualStyleBackColor = true;
            this.btnReiniciar.Click += new System.EventHandler(this.btnReiniciar_Click);
            // 
            // btnAyuda
            // 
            this.btnAyuda.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAyuda.BackgroundImage")));
            this.btnAyuda.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAyuda.ForeColor = System.Drawing.Color.White;
            this.btnAyuda.Location = new System.Drawing.Point(61, 219);
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.Size = new System.Drawing.Size(258, 39);
            this.btnAyuda.TabIndex = 3;
            this.btnAyuda.Text = "Ayuda";
            this.tTip.SetToolTip(this.btnAyuda, "Informacion a mayores");
            this.btnAyuda.UseVisualStyleBackColor = true;
            this.btnAyuda.Click += new System.EventHandler(this.btnAyuda_Click);
            // 
            // btnStats
            // 
            this.btnStats.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnStats.BackgroundImage")));
            this.btnStats.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStats.ForeColor = System.Drawing.Color.White;
            this.btnStats.Location = new System.Drawing.Point(61, 264);
            this.btnStats.Name = "btnStats";
            this.btnStats.Size = new System.Drawing.Size(258, 39);
            this.btnStats.TabIndex = 4;
            this.btnStats.Text = "Estadísticas";
            this.tTip.SetToolTip(this.btnStats, "Muestra las puntuaciones de las partidas");
            this.btnStats.UseVisualStyleBackColor = true;
            // 
            // btnTitulo
            // 
            this.btnTitulo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTitulo.BackgroundImage")));
            this.btnTitulo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTitulo.ForeColor = System.Drawing.Color.White;
            this.btnTitulo.Location = new System.Drawing.Point(20, 21);
            this.btnTitulo.Name = "btnTitulo";
            this.btnTitulo.Size = new System.Drawing.Size(341, 61);
            this.btnTitulo.TabIndex = 0;
            this.btnTitulo.Text = "Kit Breaker!";
            this.btnTitulo.UseVisualStyleBackColor = true;
            // 
            // btnJugar
            // 
            this.btnJugar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnJugar.BackgroundImage")));
            this.btnJugar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJugar.ForeColor = System.Drawing.Color.White;
            this.btnJugar.Location = new System.Drawing.Point(61, 100);
            this.btnJugar.Name = "btnJugar";
            this.btnJugar.Size = new System.Drawing.Size(258, 39);
            this.btnJugar.TabIndex = 1;
            this.btnJugar.Text = "Nueva Partida";
            this.tTip.SetToolTip(this.btnJugar, "Comenzar una nueva partida");
            this.btnJugar.UseVisualStyleBackColor = true;
            this.btnJugar.Click += new System.EventHandler(this.btnJugar_Click);
            // 
            // KitBreaker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1330, 773);
            this.Controls.Add(this.pnJuego);
            this.Controls.Add(this.pbFondoJuego);
            this.Controls.Add(this.lblMejorPuntuacion);
            this.Controls.Add(this.lblPuntuacionMedia);
            this.Controls.Add(this.lblPartidas);
            this.Controls.Add(this.lblPuntosTotales);
            this.Controls.Add(this.lblContPuntos);
            this.Controls.Add(this.lblContGatos);
            this.Controls.Add(this.pnInfo);
            this.Controls.Add(this.btnReiniciar);
            this.Controls.Add(this.btnAyuda);
            this.Controls.Add(this.btnStats);
            this.Controls.Add(this.btnTitulo);
            this.Controls.Add(this.btnJugar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "KitBreaker";
            this.Text = "Kit Breaker! ";
            ((System.ComponentModel.ISupportInitialize)(this.pbFondoJuego)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnJugar;
        private System.Windows.Forms.Button btnTitulo;
        private System.Windows.Forms.Button btnStats;
        private System.Windows.Forms.Button btnAyuda;
        private System.Windows.Forms.Button btnReiniciar;
        private System.Windows.Forms.Panel pnInfo;
        private System.Windows.Forms.Label lblContGatos;
        private System.Windows.Forms.Label lblContPuntos;
        private System.Windows.Forms.Label lblPuntosTotales;
        private System.Windows.Forms.Label lblPartidas;
        private System.Windows.Forms.Label lblPuntuacionMedia;
        private System.Windows.Forms.Label lblMejorPuntuacion;
        private System.Windows.Forms.PictureBox pbFondoJuego;
        private System.Windows.Forms.Panel pnJuego;
        private System.Windows.Forms.ToolTip tTip;
    }
}

