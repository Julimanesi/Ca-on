namespace Cañon
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.angulo = new System.Windows.Forms.NumericUpDown();
            this.veloc = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.AlturaInic = new System.Windows.Forms.NumericUpDown();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cesped = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.angulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.veloc)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AlturaInic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 266);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Disparar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // angulo
            // 
            this.angulo.Location = new System.Drawing.Point(12, 227);
            this.angulo.Maximum = new decimal(new int[] {
            90,
            0,
            0,
            0});
            this.angulo.Name = "angulo";
            this.angulo.Size = new System.Drawing.Size(110, 20);
            this.angulo.TabIndex = 3;
            // 
            // veloc
            // 
            this.veloc.Location = new System.Drawing.Point(12, 179);
            this.veloc.Name = "veloc";
            this.veloc.Size = new System.Drawing.Size(110, 20);
            this.veloc.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SkyBlue;
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.label20);
            this.panel1.Controls.Add(this.label19);
            this.panel1.Controls.Add(this.AlturaInic);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.cesped);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.veloc);
            this.panel1.Controls.Add(this.angulo);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1184, 556);
            this.panel1.TabIndex = 5;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.pictureBox3.Image = global::Cañon.Properties.Resources.escala1;
            this.pictureBox3.Location = new System.Drawing.Point(137, 539);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(1109, 16);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 25;
            this.pictureBox3.TabStop = false;
            // 
            // label20
            // 
            this.label20.Location = new System.Drawing.Point(12, 9);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(110, 95);
            this.label20.TabIndex = 6;
            this.label20.Text = "ATENCION: Por razones de escala el movimiento de la pelota se muestra para una di" +
    "stancia recorrida > 24m o una altura máxima> 35m.";
            // 
            // label19
            // 
            this.label19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label19.Location = new System.Drawing.Point(137, 533);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(37, 12);
            this.label19.TabIndex = 24;
            // 
            // AlturaInic
            // 
            this.AlturaInic.Location = new System.Drawing.Point(12, 127);
            this.AlturaInic.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.AlturaInic.Name = "AlturaInic";
            this.AlturaInic.Size = new System.Drawing.Size(110, 20);
            this.AlturaInic.TabIndex = 23;
            this.AlturaInic.ValueChanged += new System.EventHandler(this.AlturaCambiada);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(12, 111);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(66, 13);
            this.label18.TabIndex = 6;
            this.label18.Text = "Altura inicial:";
            // 
            // label17
            // 
            this.label17.Image = ((System.Drawing.Image)(resources.GetObject("label17.Image")));
            this.label17.Location = new System.Drawing.Point(370, 89);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(17, 15);
            this.label17.TabIndex = 22;
            this.label17.Visible = false;
            // 
            // label16
            // 
            this.label16.Image = ((System.Drawing.Image)(resources.GetObject("label16.Image")));
            this.label16.Location = new System.Drawing.Point(347, 89);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(17, 15);
            this.label16.TabIndex = 21;
            this.label16.Visible = false;
            // 
            // label15
            // 
            this.label15.Image = ((System.Drawing.Image)(resources.GetObject("label15.Image")));
            this.label15.Location = new System.Drawing.Point(324, 89);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(17, 15);
            this.label15.TabIndex = 20;
            this.label15.Visible = false;
            // 
            // label14
            // 
            this.label14.Image = ((System.Drawing.Image)(resources.GetObject("label14.Image")));
            this.label14.Location = new System.Drawing.Point(301, 89);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(17, 15);
            this.label14.TabIndex = 19;
            this.label14.Visible = false;
            // 
            // label13
            // 
            this.label13.Image = ((System.Drawing.Image)(resources.GetObject("label13.Image")));
            this.label13.Location = new System.Drawing.Point(278, 89);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(17, 15);
            this.label13.TabIndex = 18;
            this.label13.Visible = false;
            // 
            // label12
            // 
            this.label12.Image = ((System.Drawing.Image)(resources.GetObject("label12.Image")));
            this.label12.Location = new System.Drawing.Point(255, 89);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(17, 15);
            this.label12.TabIndex = 17;
            this.label12.Visible = false;
            // 
            // label11
            // 
            this.label11.Image = ((System.Drawing.Image)(resources.GetObject("label11.Image")));
            this.label11.Location = new System.Drawing.Point(232, 89);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(17, 15);
            this.label11.TabIndex = 16;
            this.label11.Visible = false;
            // 
            // label10
            // 
            this.label10.Image = ((System.Drawing.Image)(resources.GetObject("label10.Image")));
            this.label10.Location = new System.Drawing.Point(209, 89);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(17, 15);
            this.label10.TabIndex = 15;
            this.label10.Visible = false;
            // 
            // label9
            // 
            this.label9.Image = ((System.Drawing.Image)(resources.GetObject("label9.Image")));
            this.label9.Location = new System.Drawing.Point(177, 89);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(17, 15);
            this.label9.TabIndex = 6;
            this.label9.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(137, 495);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(37, 38);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(140, 521);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(12, 12);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // cesped
            // 
            this.cesped.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.cesped.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cesped.Location = new System.Drawing.Point(0, 533);
            this.cesped.Name = "cesped";
            this.cesped.Size = new System.Drawing.Size(1184, 23);
            this.cesped.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(12, 462);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 23);
            this.label8.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 441);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Altura máxima (m);";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(12, 418);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 23);
            this.label6.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(12, 365);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 23);
            this.label5.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 335);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tiempo Total (s):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 388);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Distancia recorrida(m):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Velocidad(m/s)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 211);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ángulo(°)";
            // 
            // timer1
            // 
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1184, 556);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1200, 594);
            this.MinimumSize = new System.Drawing.Size(1200, 594);
            this.Name = "Form1";
            this.Text = "Cañon (tiro oblicuo)                                                             " +
    "      Autor: Julián Manesi";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.angulo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.veloc)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AlturaInic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown angulo;
        private System.Windows.Forms.NumericUpDown veloc;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label cesped;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.NumericUpDown AlturaInic;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.PictureBox pictureBox3;

    }
}

