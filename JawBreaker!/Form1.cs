using JawBreaker_.Properties;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Xsl;

namespace JawBreaker_
{
    public partial class KitBreaker : Form
    {
        /**
         * KIT BREAKER!
         * 
         * El juego consiste en un alineador de bloques, cuantos más bloques juntos selecciones, más puntos te llevarás y menos bloques habrá, el objetivo es el de quedarte sin bloques en pantalla, pues estos no se regeneran una vez has destruido un conjunto, el programa guarda un historial con los puntos y el total de partidas jugadas por cada jugador
         * 
         */

        Random g = new Random();

        int PartidasJugadas = 0;
        int puntuacionMedia = 0;
        int puntuacionMaxima = 0;

        // - - - - - - - - Declaracion de atributos de los bloques - - - - - - - - 

        List<Button> bloques = new List<Button>();
        List<int> romper = new List<int>();


        Image[] gatos = new Image[]
            {
                Resources.gatoBlanco,
                Resources.gatoAzul,
                Resources.gatoMarron,
                Resources.gatoNaranja,
                Resources.gatoNegro
            };

        int x = 15;
        int y = 5;

        int width = 40;
        int height = 40;

        public KitBreaker()
        {
            InitializeComponent();

            //Total de bloques a crear --> 11 Columnas * 12 Filas = 132 bloques
            for (int i = 0; i < 132; i++)
            {
                Button btn = new Button();

                btn.Location = new Point(x, y);

                if ((i + 1) % 11 == 0)
                {
                    x = 15;
                    y = y + 45;
                }
                else
                {
                    x = x + 45;
                }

                btn.TabStop = false;
                btn.Size = new Size(width, height);
                btn.BackColor = Color.White;

                btn.MouseEnter += ratonEnBoton;
                btn.MouseLeave += ratonFueraDeBoton;

                int num = g.Next(0, 5);

                btn.BackgroundImage = gatos[num];
                btn.BackgroundImageLayout = ImageLayout.Stretch;
                btn.Click += clicarBloque;

                bloques.Add(btn);
                pnJuego.Controls.Add(btn);
            }

            // - - - - - - - - Declaracion de los atributos del panel informativo - - - - - - - - 

            x = 5;
            y = 5;

            int xCont = x + 22;
            int yCont = y + 45;

            width = 45;
            height = 45;

            for (int i = 0; i < 5; i++)
            {
                PictureBox gato = new PictureBox();

                gato.Location = new Point(x, y);

                gato.Size = new Size(width, height);

                gato.Image = gatos[i];
                gato.SizeMode = PictureBoxSizeMode.StretchImage;

                pnInfo.Controls.Add(gato);

                //Añadir los contadores de cada uno de los gatos

                //Label ContGatos = new Label();

                //lblContGatos.BackColor = Color.White;

                //lblContGatos.Location = new Point(xCont, yCont);
                //lblContGatos.Text = i.ToString();

                //pnInfo.Controls.Add(ContGatos);

                //xCont = x + 22;
                x = x + 50;

            }

            lblContGatos.Text = $"Contador Bloques: {bloques.Count()}";
            lblContPuntos.Text = "Contador Puntuacion: 0";
            lblPuntosTotales.Text = "Puntuación total: 0";

            PartidasJugadas++;

            lblPartidas.Text = $"Partidas jugadas: {PartidasJugadas}";
            lblPuntuacionMedia.Text = $"Puntuacion media: {puntuacionMedia}";
            lblMejorPuntuacion.Text = $"Mejor puntuacion: {puntuacionMaxima}";
        }

        public void actualizarBloques()
        {
            for (int i = 0; i < romper.Count; i++)//Eliminar bloques elegidos
            {
                bloques[romper[i]] = null;
            }

            //Actualizar posicion
            int c = -1;
            for (int i = 11; i >= 0; i--) //filas 
            {

                for (int j = 10; j >= 0; j--) //columnas
                {
                    c++;

                    if (bloques[i] != null)
                    {
                        if (i < 11 && bloques[i + 11] == null)//De la fila 0 a la fila 10 funciona igual --> bloque debajo
                        {
                            bloques.Insert(c + 11, bloques[c]);
                            bloques[c] = null;
                        }

                        //Añadir para que se muevan a la izquierda también
                    }

                }
            }
            MessageBox.Show(depurador());

            pnJuego.Controls.Clear();

            for (int i = 0; i < bloques.Count; i++)
            {
                pnJuego.Controls.Add(bloques[i]);
            }
        }

        public string depurador()
        {
            string res = "Bloques: " + Environment.NewLine;
            for (int i = 0; i < bloques.Count; i++)
            {
                if (i % 11 == 0)
                {
                    res += Environment.NewLine;
                    res += Environment.NewLine;

                }
                if (bloques[i] == null)
                {
                    res += " | ";
                }
                else
                {
                    res += " " + i;
                }

            }

            res += Environment.NewLine + "Romper: " + Environment.NewLine;
            for (int i = 0; i < romper.Count; i++)
            {
                res += " " + romper[i];
            }
            return res;
        }

        public void reiniciarJuego(bool bandera)
        {
            x = 15;
            y = 5;

            bloques.Clear();
            romper.Clear();

            pnJuego.Controls.Clear();

            for (int i = 0; i < 132; i++)
            {
                Button btn = new Button();

                btn.Location = new Point(x, y);

                if ((i + 1) % 11 == 0)
                {
                    x = 15;
                    y = y + 45;
                }
                else
                {
                    x = x + 45;
                }

                btn.TabStop = false;
                btn.Size = new Size(width, height);
                btn.BackColor = Color.White;

                btn.MouseEnter += ratonEnBoton;
                btn.MouseLeave += ratonFueraDeBoton;

                int num = g.Next(0, 5);

                btn.BackgroundImage = gatos[num];
                btn.BackgroundImageLayout = ImageLayout.Stretch;
                btn.Click += clicarBloque;

                bloques.Add(btn);
                pnJuego.Controls.Add(btn);
            }


            lblContGatos.Text = $"Contador Bloques: {bloques.Count()}";
            lblContPuntos.Text = "Contador Puntuacion: 0";
            lblPuntosTotales.Text = "Puntuación total: 0";

            if (bandera)
            {
                PartidasJugadas++;
            }
            else
            {
                PartidasJugadas = 1;
                puntuacionMedia = 0;
                puntuacionMaxima = 0;
            }
            lblPartidas.Text = $"Partidas jugadas: {PartidasJugadas}";

        }

        private void ratonEnBoton(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            btn.BackColor = Color.Black;
        }

        private void ratonFueraDeBoton(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            btn.BackColor = Color.White;
        }

        private void btnJugar_Click(object sender, EventArgs e)
        {
            reiniciarJuego(true);

        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {

            reiniciarJuego(false);
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            Ayuda f2 = new Ayuda();

            f2.Show();
        }

        private void clicarBloque(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            bool encontrado = false;
            romper.Clear();

            //Bucle para detectar los bloques con la misma imagen al rededor del bloque seleccionado
            int c = -1;
            for (int i = 0; i < 12; i++) //filas 
            {

                for (int j = 0; j < 11; j++) //columnas
                {
                    c++;
                    try
                    {
                        if (bloques[c] == btn)

                        {
                            encontrado = false;
                            if (i == 0)//Fila 0
                            {
                                if (j > 0 && bloques[c - 1].BackgroundImage == btn.BackgroundImage)//Excepcion si se trata del primer elemento de la columna 
                                {
                                    encontrado = true;
                                    romper.Add(c - 1);
                                }

                                if (bloques[c + 11].BackgroundImage == btn.BackgroundImage)
                                {
                                    encontrado = true;
                                    romper.Add(c + 11);
                                }

                                if (j < 10 && bloques[c + 1].BackgroundImage == btn.BackgroundImage)//Excepcion si se trata del ultimo elemento de la columna 
                                {
                                    encontrado = true;
                                    romper.Add(c + 1);
                                }
                            }

                            if (i > 0 && i < 11)//Filas 1 a 10
                            {
                                if (j > 0 && bloques[c - 1].BackgroundImage == btn.BackgroundImage)//Excepcion si se trata del primer elemento de la columna 
                                {
                                    encontrado = true;
                                    romper.Add(c - 1);
                                }

                                if (bloques[c + 11].BackgroundImage == btn.BackgroundImage)
                                {
                                    encontrado = true;
                                    romper.Add(c + 11);
                                }

                                if (bloques[c - 11].BackgroundImage == btn.BackgroundImage)
                                {
                                    encontrado = true;
                                    romper.Add(c - 11);
                                }

                                if (j < 10 && bloques[c + 1].BackgroundImage == btn.BackgroundImage)//Excepcion si se trata del ultimo elemento de la columna 
                                {
                                    encontrado = true;
                                    romper.Add(c + 1);
                                }
                            }

                            if (i == 11)//Fila 11
                            {
                                if (j > 0 && bloques[c - 1].BackgroundImage == btn.BackgroundImage)//Excepcion si se trata del primer elemento de la columna 
                                {
                                    encontrado = true;
                                    romper.Add(c - 1);
                                }

                                if (bloques[c - 11].BackgroundImage == btn.BackgroundImage)
                                {
                                    encontrado = true;
                                    romper.Add(c - 11);
                                }

                                if (j < 10 && bloques[c + 1].BackgroundImage == btn.BackgroundImage)//Excepcion si se trata del ultimo elemento de la columna 
                                {
                                    encontrado = true;
                                    romper.Add(c + 1);
                                }
                            }

                            if (encontrado)
                            {
                                romper.Add(c);
                            }

                        }
                    }
                    catch (NullReferenceException)
                    {

                    }
                }
            }

            if (romper.Count > 0)
            {
                MessageBox.Show($"{romper.Count}", "prueba", MessageBoxButtons.OK);
                actualizarBloques();


            }

        }
    }
}
