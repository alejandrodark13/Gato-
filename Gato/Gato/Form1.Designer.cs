namespace Gato
{
    partial class Form1
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
            this.btnA1 = new System.Windows.Forms.Button();
            this.btnA2 = new System.Windows.Forms.Button();
            this.btnA3 = new System.Windows.Forms.Button();
            this.btnB1 = new System.Windows.Forms.Button();
            this.btnB2 = new System.Windows.Forms.Button();
            this.btnB3 = new System.Windows.Forms.Button();
            this.btnC1 = new System.Windows.Forms.Button();
            this.btnC2 = new System.Windows.Forms.Button();
            this.btnC3 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.juegoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoJuegoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetAlMarcadorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.holaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.GanadosX = new System.Windows.Forms.Label();
            this.empates = new System.Windows.Forms.Label();
            this.GanadoO = new System.Windows.Forms.Label();
            this.tbJugador1 = new System.Windows.Forms.TextBox();
            this.tbJugador2 = new System.Windows.Forms.TextBox();
            this.jugadoresDefaultToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnA1
            // 
            this.btnA1.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnA1.Location = new System.Drawing.Point(12, 27);
            this.btnA1.Name = "btnA1";
            this.btnA1.Size = new System.Drawing.Size(102, 83);
            this.btnA1.TabIndex = 0;
            this.btnA1.UseVisualStyleBackColor = true;
            this.btnA1.Click += new System.EventHandler(this.ClicBoton);
            this.btnA1.MouseEnter += new System.EventHandler(this.BtnRozon);
            this.btnA1.MouseLeave += new System.EventHandler(this.BtnSalir);
            // 
            // btnA2
            // 
            this.btnA2.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnA2.Location = new System.Drawing.Point(120, 27);
            this.btnA2.Name = "btnA2";
            this.btnA2.Size = new System.Drawing.Size(102, 83);
            this.btnA2.TabIndex = 1;
            this.btnA2.UseVisualStyleBackColor = true;
            this.btnA2.Click += new System.EventHandler(this.ClicBoton);
            this.btnA2.MouseEnter += new System.EventHandler(this.BtnRozon);
            this.btnA2.MouseLeave += new System.EventHandler(this.BtnSalir);
            // 
            // btnA3
            // 
            this.btnA3.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnA3.Location = new System.Drawing.Point(228, 27);
            this.btnA3.Name = "btnA3";
            this.btnA3.Size = new System.Drawing.Size(102, 83);
            this.btnA3.TabIndex = 2;
            this.btnA3.UseVisualStyleBackColor = true;
            this.btnA3.Click += new System.EventHandler(this.ClicBoton);
            this.btnA3.MouseEnter += new System.EventHandler(this.BtnRozon);
            this.btnA3.MouseLeave += new System.EventHandler(this.BtnSalir);
            // 
            // btnB1
            // 
            this.btnB1.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnB1.Location = new System.Drawing.Point(12, 116);
            this.btnB1.Name = "btnB1";
            this.btnB1.Size = new System.Drawing.Size(102, 83);
            this.btnB1.TabIndex = 3;
            this.btnB1.UseVisualStyleBackColor = true;
            this.btnB1.Click += new System.EventHandler(this.ClicBoton);
            this.btnB1.MouseEnter += new System.EventHandler(this.BtnRozon);
            this.btnB1.MouseLeave += new System.EventHandler(this.BtnSalir);
            // 
            // btnB2
            // 
            this.btnB2.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnB2.Location = new System.Drawing.Point(120, 116);
            this.btnB2.Name = "btnB2";
            this.btnB2.Size = new System.Drawing.Size(102, 83);
            this.btnB2.TabIndex = 4;
            this.btnB2.UseVisualStyleBackColor = true;
            this.btnB2.Click += new System.EventHandler(this.ClicBoton);
            this.btnB2.MouseEnter += new System.EventHandler(this.BtnRozon);
            this.btnB2.MouseLeave += new System.EventHandler(this.BtnSalir);
            // 
            // btnB3
            // 
            this.btnB3.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnB3.Location = new System.Drawing.Point(228, 116);
            this.btnB3.Name = "btnB3";
            this.btnB3.Size = new System.Drawing.Size(102, 83);
            this.btnB3.TabIndex = 5;
            this.btnB3.UseVisualStyleBackColor = true;
            this.btnB3.Click += new System.EventHandler(this.ClicBoton);
            this.btnB3.MouseEnter += new System.EventHandler(this.BtnRozon);
            this.btnB3.MouseLeave += new System.EventHandler(this.BtnSalir);
            // 
            // btnC1
            // 
            this.btnC1.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnC1.Location = new System.Drawing.Point(12, 205);
            this.btnC1.Name = "btnC1";
            this.btnC1.Size = new System.Drawing.Size(102, 83);
            this.btnC1.TabIndex = 6;
            this.btnC1.UseVisualStyleBackColor = true;
            this.btnC1.Click += new System.EventHandler(this.ClicBoton);
            this.btnC1.MouseEnter += new System.EventHandler(this.BtnRozon);
            this.btnC1.MouseLeave += new System.EventHandler(this.BtnSalir);
            // 
            // btnC2
            // 
            this.btnC2.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnC2.Location = new System.Drawing.Point(120, 205);
            this.btnC2.Name = "btnC2";
            this.btnC2.Size = new System.Drawing.Size(102, 83);
            this.btnC2.TabIndex = 7;
            this.btnC2.UseVisualStyleBackColor = true;
            this.btnC2.Click += new System.EventHandler(this.ClicBoton);
            this.btnC2.MouseEnter += new System.EventHandler(this.BtnRozon);
            this.btnC2.MouseLeave += new System.EventHandler(this.BtnSalir);
            // 
            // btnC3
            // 
            this.btnC3.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnC3.Location = new System.Drawing.Point(228, 205);
            this.btnC3.Name = "btnC3";
            this.btnC3.Size = new System.Drawing.Size(102, 83);
            this.btnC3.TabIndex = 8;
            this.btnC3.UseVisualStyleBackColor = true;
            this.btnC3.Click += new System.EventHandler(this.ClicBoton);
            this.btnC3.MouseEnter += new System.EventHandler(this.BtnRozon);
            this.btnC3.MouseLeave += new System.EventHandler(this.BtnSalir);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.juegoToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(345, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // juegoToolStripMenuItem
            // 
            this.juegoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoJuegoToolStripMenuItem,
            this.jugadoresDefaultToolStripMenuItem,
            this.resetAlMarcadorToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.juegoToolStripMenuItem.Name = "juegoToolStripMenuItem";
            this.juegoToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.juegoToolStripMenuItem.Text = "Juego";
            // 
            // nuevoJuegoToolStripMenuItem
            // 
            this.nuevoJuegoToolStripMenuItem.Name = "nuevoJuegoToolStripMenuItem";
            this.nuevoJuegoToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.nuevoJuegoToolStripMenuItem.Text = "Nuevo juego";
            this.nuevoJuegoToolStripMenuItem.Click += new System.EventHandler(this.NuevoJuegoToolStripMenuItem_Click);
            // 
            // resetAlMarcadorToolStripMenuItem
            // 
            this.resetAlMarcadorToolStripMenuItem.Name = "resetAlMarcadorToolStripMenuItem";
            this.resetAlMarcadorToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.resetAlMarcadorToolStripMenuItem.Text = "Reset al marcador";
            this.resetAlMarcadorToolStripMenuItem.Click += new System.EventHandler(this.resetAlMarcadorToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.holaToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.ayudaToolStripMenuItem.Text = "Hecho por";
            this.ayudaToolStripMenuItem.Click += new System.EventHandler(this.ayudaToolStripMenuItem_Click);
            // 
            // holaToolStripMenuItem
            // 
            this.holaToolStripMenuItem.Name = "holaToolStripMenuItem";
            this.holaToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.holaToolStripMenuItem.Text = "Hola";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(146, 303);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Empates";
            // 
            // GanadosX
            // 
            this.GanadosX.AutoSize = true;
            this.GanadosX.Location = new System.Drawing.Point(51, 326);
            this.GanadosX.Name = "GanadosX";
            this.GanadosX.Size = new System.Drawing.Size(13, 13);
            this.GanadosX.TabIndex = 14;
            this.GanadosX.Text = "0";
            // 
            // empates
            // 
            this.empates.AutoSize = true;
            this.empates.Location = new System.Drawing.Point(161, 326);
            this.empates.Name = "empates";
            this.empates.Size = new System.Drawing.Size(13, 13);
            this.empates.TabIndex = 15;
            this.empates.Text = "0";
            // 
            // GanadoO
            // 
            this.GanadoO.AutoSize = true;
            this.GanadoO.Location = new System.Drawing.Point(270, 326);
            this.GanadoO.Name = "GanadoO";
            this.GanadoO.Size = new System.Drawing.Size(13, 13);
            this.GanadoO.TabIndex = 16;
            this.GanadoO.Text = "0";
            // 
            // tbJugador1
            // 
            this.tbJugador1.Location = new System.Drawing.Point(14, 303);
            this.tbJugador1.Name = "tbJugador1";
            this.tbJugador1.Size = new System.Drawing.Size(100, 20);
            this.tbJugador1.TabIndex = 17;
            this.tbJugador1.Text = "Jugador 1";
            this.tbJugador1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbJugador2
            // 
            this.tbJugador2.Location = new System.Drawing.Point(228, 300);
            this.tbJugador2.Name = "tbJugador2";
            this.tbJugador2.Size = new System.Drawing.Size(100, 20);
            this.tbJugador2.TabIndex = 18;
            this.tbJugador2.Text = "Jugador 2";
            this.tbJugador2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbJugador2.TextChanged += new System.EventHandler(this.tbJugador2_TextChanged);
            // 
            // jugadoresDefaultToolStripMenuItem
            // 
            this.jugadoresDefaultToolStripMenuItem.Name = "jugadoresDefaultToolStripMenuItem";
            this.jugadoresDefaultToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.jugadoresDefaultToolStripMenuItem.Text = "Jugadores Default";
            this.jugadoresDefaultToolStripMenuItem.Click += new System.EventHandler(this.jugadoresDefaultToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 351);
            this.Controls.Add(this.tbJugador2);
            this.Controls.Add(this.tbJugador1);
            this.Controls.Add(this.GanadoO);
            this.Controls.Add(this.empates);
            this.Controls.Add(this.GanadosX);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnC3);
            this.Controls.Add(this.btnC2);
            this.Controls.Add(this.btnC1);
            this.Controls.Add(this.btnB3);
            this.Controls.Add(this.btnB2);
            this.Controls.Add(this.btnB1);
            this.Controls.Add(this.btnA3);
            this.Controls.Add(this.btnA2);
            this.Controls.Add(this.btnA1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gato";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnA1;
        private System.Windows.Forms.Button btnA2;
        private System.Windows.Forms.Button btnA3;
        private System.Windows.Forms.Button btnB1;
        private System.Windows.Forms.Button btnB2;
        private System.Windows.Forms.Button btnB3;
        private System.Windows.Forms.Button btnC1;
        private System.Windows.Forms.Button btnC2;
        private System.Windows.Forms.Button btnC3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem juegoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoJuegoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem holaToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label GanadosX;
        private System.Windows.Forms.Label empates;
        private System.Windows.Forms.Label GanadoO;
        private System.Windows.Forms.ToolStripMenuItem resetAlMarcadorToolStripMenuItem;
        private System.Windows.Forms.TextBox tbJugador1;
        private System.Windows.Forms.TextBox tbJugador2;
        private System.Windows.Forms.ToolStripMenuItem jugadoresDefaultToolStripMenuItem;
    }
}

