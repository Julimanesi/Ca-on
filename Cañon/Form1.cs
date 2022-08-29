using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Cañon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            a = pictureBox1.Location.X;
            b = pictureBox1.Location.Y;
            i = a;//inicializo en el lugar donde se encuentra la pelota
            j = b;
            c = pictureBox2.Location.Y;
            d = label19.Location.Y;
            f =(int) label1.Size.Height;
        }

        int i, j,a,b,c,d,f;
        double Vx, Vy,tiempo,dist,altura,t=0.0;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Vx = (double)veloc.Value * Math.Cos((double)angulo.Value * Math.PI / 180); //Calculo velocidad, tiempo, altura y distancia
            Vy = (double)veloc.Value * Math.Sin((double)angulo.Value * Math.PI / 180) ;
            if ((-Vy + Math.Sqrt(Vy * Vy - 4 * (-4.9) * (double)AlturaInic.Value)) / (2 * (-4.9)) > 0) {tiempo=(-Vy + Math.Sqrt(Vy * Vy - 4 * (-4.9) * (double)AlturaInic.Value)) / (2 * (-4.9)); }
            else {tiempo=(-Vy - Math.Sqrt(Vy * Vy - 4 * (-4.9) * (double)AlturaInic.Value)) / (2 * (-4.9)); }
            dist = Vx * tiempo;
            altura = (double)AlturaInic.Value + Vy * (Vy / 9.8) - 4.9 * Math.Pow(Vy / 9.8, 2);
            label5.Text = Math.Round(tiempo, 2).ToString();//redondeo los resultados y muestro los resultados
            label6.Text = Math.Round(dist, 2).ToString();
            label8.Text = Math.Round(altura, 2).ToString();
            timer1.Start();//inicio el movimiento
            posicCañon();//muevo la imagen del cañon
            if (i != a || b!=j) { inicio(); button1.Text = "Disparar"; }
            else { button1.Text = "Reiniciar"; }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Point bola_p = panel1.Location;
            i = a + (int)(Vx * t);//ecuac. posicion en funcion del tiempo para velocidad const
            j = b - (int)AlturaInic.Value - (int)(Vy * t - 4.9 * Math.Pow(t, 2));//ecuac. posicion en funcion del tiempo para aceleracion  const (gravedad)
            if ((i < panel1.Size.Width - pictureBox1.Size.Width / 2 - 1 || i < panel1.Size.Width) && (AlturaInic.Value != 0 || angulo.Value != 0) && (j + pictureBox1.Size.Height < cesped.Location.Y + 3))
            {
                bola_p.Offset(i, j);
                pictureBox1.Location = bola_p;//mueve la pelota
            }
            else//si la pelota esta cerca de salirse de la pantalla
            {
                if (j + pictureBox1.Size.Height >= cesped.Location.Y)//si la pelota alcanza el suelo, apollar la pelota al raz del suelo y detenerse
                {
                    bola_p.Offset(i , cesped.Location.Y - pictureBox1.Size.Height);
                    pictureBox1.Location = bola_p;
                }
                else //si la pelota choca contra la pared, detenerse y caer en vertical
                {
                    bola_p.Offset(panel1.Size.Width - pictureBox1.Size.Width, j - pictureBox1.Size.Height);
                    pictureBox1.Location = bola_p;
                }
                timer1.Stop();
            }
            t += 0.1;//avanza el tiempo
            
        }

        private void inicio()
        {
            Point bola_p = panel1.Location;
            bola_p.Offset(a, b);//mueve la pelota a su posicion inicial
            pictureBox1.Location = bola_p;
            t = 0.0;//regresa el tiempo a 0
            i = a;//pone las variables x e y en su posicion inicial
            j = b;
            timer1.Stop();//detiene el movimiento de la pelota
        }
        private void posicCañon() 
        {//carga una imagen del cañon dependiendo el angulo ingresado
            if (angulo.Value < 5) pictureBox2.Image=pictureBox2.BackgroundImage;
            if (angulo.Value >= 5 && angulo.Value < 15) pictureBox2.Image = label9.Image;
            if (angulo.Value >= 15 && angulo.Value < 25) pictureBox2.Image = label10.Image;
            if (angulo.Value >= 25 && angulo.Value < 35) pictureBox2.Image = label11.Image;
            if (angulo.Value >= 35 && angulo.Value < 45) pictureBox2.Image = label12.Image;
            if (angulo.Value >= 45 && angulo.Value < 55) pictureBox2.Image = label13.Image;
            if (angulo.Value >= 55 && angulo.Value < 65) pictureBox2.Image = label14.Image;
            if (angulo.Value >= 65 && angulo.Value < 75) pictureBox2.Image = label15.Image;
            if (angulo.Value >= 75 && angulo.Value < 85) pictureBox2.Image = label16.Image;
            if (angulo.Value >= 85 && angulo.Value <= 90) pictureBox2.Image = label17.Image;
        }
        //Si la altura es diferente de 0 el cañon debe moverse y la pelota debe cambiar su posición inicial
        private void AlturaCambiada(object sender, EventArgs e)
        {
            Point bola_p = panel1.Location;
            bola_p.Offset(pictureBox2.Location.X, c - (int)AlturaInic.Value);
            pictureBox2.Location = bola_p;
            Point piso = panel1.Location;
            piso.Offset(label19.Location.X, d - (int)AlturaInic.Value);
            label19.Location = piso;
            label19.Size = new Size(30, f + (int)AlturaInic.Value);
        }
      
       
    }
}
