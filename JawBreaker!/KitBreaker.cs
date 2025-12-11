using JawBreaker_.Properties;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Xsl;
using System.Media;




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

        //- - - - - - - - Datos de las partidas - - - - - - - - 

        List<string> datosPartidas = new List<string>(); // Cada partida finalizada registrará un nombre y su puntuacion --> nombre : puntuacion
        List<string> datosHistoricos = new List<string>();

        int PartidasJugadas = 0;
        int puntuacionMedia = 0;
        int puntuacionMaxima = 0;

        int puntuacionActual = 0;   // puntos en la partida actual
        int puntuacionTotal = 0;    // puntos acumulados históricamente

        string archivo = "estadisticas.txt";
        bool existe = false;

        // - - - - - - - - Declaracion de atributos de los bloques - - - - - - - - 

        List<Button> bloques = new List<Button>();
        List<int> romper = new List<int>();

        int[] fueraDeRango = new int[] { -11, -1, 1, 11 };


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
                btn.Tag = i;

                btn.MouseEnter += ratonEnBoton;
                btn.MouseLeave += ratonFueraDeBoton;

                int num = g.Next(0, 5);

                btn.BackgroundImage = gatos[num];
                btn.BackgroundImageLayout = ImageLayout.Stretch;
                btn.Click += clicarBloque;

                bloques.Add(btn);
                pnJuego.Controls.Add(btn);
            }

            if (File.Exists(archivo))
            {
                existe = true;

                try
                {
                    using (StreamReader sr = new StreamReader(archivo))
                    {
                        string linea = sr.ReadLine();
                        while (linea != null)
                        {
                            datosHistoricos.Add(linea);
                            linea = sr.ReadLine();
                        }
                    }
                }
                catch (FileNotFoundException)
                {
                    Console.WriteLine("No se encuentra el archivo");
                }

                catch (IOException)
                {
                    Console.WriteLine("Error en el archivo");
                }
            }
            else
            {
                existe = false;
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

                x = x + 50;

            }

            lblContGatos.Text = $"Contador Bloques: {bloques.Count()}";
            lblContPuntos.Text = "Contador Puntuacion: 0";
            lblPuntosTotales.Text = "Puntuación total: 0";

            PartidasJugadas++;

            lblPartidas.Text = $"Partidas jugadas: {PartidasJugadas}";
            lblPuntuacionMedia.Text = $"Puntuacion media: {puntuacionMedia}";
            lblMejorPuntuacion.Text = $"Mejor puntuacion: {puntuacionMaxima}";

            //Musica de fondo

            SoundPlayer sonido = new SoundPlayer(Properties.Resources.mBase);
            sonido.PlayLooping();
        }

        private void verEstadisticas(object sender, EventArgs e)
        {
            Estadisticas stats = new Estadisticas();

            if (datosPartidas.Count == 0)
            {
                stats.lblPartidaActual.Text = "Sin datos actuales";
                stats.lsActual.Visible = false;
            }
            else
            {
                stats.lblPartidaActual.Text = "Partidas Actuales";
                stats.lsActual.Visible = true;

                foreach (string dato in datosPartidas)
                {
                    stats.lsActual.Items.Add(dato);
                }
            }

            if (datosHistoricos.Count != 0)
            {
                stats.lblHistorico.Text = "Registro Historico";
                foreach (string s in datosHistoricos)
                {
                    stats.lsHistorico.Items.Add(s);
                }
            }

            if (datosHistoricos.Count == 0 && datosPartidas.Count == 0)
            {
                MessageBox.Show("Aun no hay datos en las estadísticas, juega partidas para almacenar records ( •̀ ω •́ )✧!!", "Sin datos", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                if (stats.DialogResult == DialogResult.OK)
                {
                    using (StreamWriter sw = new StreamWriter(archivo, existe))
                    {
                        foreach (string s in stats.lsHistorico.Items)
                        {
                            sw.WriteLine(s);
                        }
                    }
                }
            }
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

        // - - - - - - - - Logica principal del programa - - - - - - - - 
        public void actualizarBloques()
        {
            // 1. Eliminar los bloques seleccionados
            foreach (int index in romper)
            {
                if (bloques[index] != null)
                {
                    bloques[index].Visible = false;
                    bloques[index] = null;
                }
            }

            if (bloques.Count > 0)
            {
                int puntos = (romper.Count * (romper.Count - 1)) / 2;
                puntuacionActual += puntos;
                puntuacionTotal += puntos;

                // Actualizar etiquetas
                lblContPuntos.Text = $"Contador Puntuación: {puntuacionActual}";
                lblPuntosTotales.Text = $"Puntuación total: {puntuacionTotal}";
            }

            romper.Clear();

            // 2. Aplicar gravedad vertical
            for (int col = 0; col < 11; col++)
            {
                List<Button> columna = new List<Button>();
                // Recoger solo bloques
                for (int fila = 0; fila < 12; fila++)
                {
                    int idx = fila * 11 + col;
                    if (bloques[idx] != null)
                        columna.Add(bloques[idx]);
                }
                // Rellenar arriba con null
                while (columna.Count < 12)
                    columna.Insert(0, null);

                // Reasignar a bloques
                for (int fila = 0; fila < 12; fila++)
                    bloques[fila * 11 + col] = columna[fila];
            }

            // 3. Compactar columnas hacia la derecha
            List<List<Button>> columnas = new List<List<Button>>();

            for (int col = 0; col < 11; col++)
            {
                List<Button> colLista = new List<Button>();
                bool vacia = true;
                for (int fila = 0; fila < 12; fila++)
                {
                    Button b = bloques[fila * 11 + col];
                    colLista.Add(b);
                    if (b != null) vacia = false;
                }
                if (!vacia)
                    columnas.Add(colLista);
            }

            // Crear nueva matriz vacía
            Button[,] nuevaMatriz = new Button[12, 11];
            int colPos = 10; // empezar desde la derecha
            for (int i = columnas.Count - 1; i >= 0; i--)
            {
                List<Button> colLista = columnas[i];
                for (int fila = 0; fila < 12; fila++)
                {
                    nuevaMatriz[fila, colPos] = colLista[fila];
                }
                colPos--;
            }

            // 4. Actualizar bloques y posiciones visuales
            for (int fila = 0; fila < 12; fila++)
            {
                for (int col = 0; col < 11; col++)
                {
                    int idx = fila * 11 + col;
                    Button b = nuevaMatriz[fila, col];
                    bloques[idx] = b;
                    if (b != null)
                    {
                        b.Visible = true;
                        b.Location = new Point(15 + col * 45, 5 + fila * 45);
                        b.Tag = idx;
                    }
                }
            }

            //Comprobar si quedan movimientos por hacer
            if (!QuedanMovimientos())
            {
                //Actualizar puntuaciones
                puntuacionMaxima = Math.Max(puntuacionMaxima, puntuacionActual);
                puntuacionMedia = (puntuacionMedia * (PartidasJugadas - 1) + puntuacionActual) / PartidasJugadas;

                lblPuntuacionMedia.Text = $"Puntuación media: {puntuacionMedia}";
                lblMejorPuntuacion.Text = $"Mejor puntuación: {puntuacionMaxima}";

                FinPartida();
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
            // 1. Limpiar botones viejos
            foreach (Button btn in pnJuego.Controls.OfType<Button>().ToList())
            {
                btn.Click -= clicarBloque;  // quitar evento para evitar referencias
                pnJuego.Controls.Remove(btn);
                btn.Dispose();
            }

            bloques.Clear();
            romper.Clear();

            // 2. Crear nuevos botones
            int xPos = 15;
            int yPos = 5;

            for (int i = 0; i < 132; i++)
            {
                Button btn = new Button
                {
                    Size = new Size(width, height),
                    BackColor = Color.White,
                    TabStop = false,
                    Tag = i // Asignar Tag correctamente
                };

                btn.Location = new Point(xPos, yPos);
                if ((i + 1) % 11 == 0)
                {
                    xPos = 15;
                    yPos += 45;
                }
                else
                {
                    xPos += 45;
                }

                // Imagen aleatoria
                int num = g.Next(0, 5);
                btn.BackgroundImage = gatos[num];
                btn.BackgroundImageLayout = ImageLayout.Stretch;

                // Eventos
                btn.Click += clicarBloque;
                btn.MouseEnter += ratonEnBoton;
                btn.MouseLeave += ratonFueraDeBoton;

                // Añadir al panel y a la lista de bloques
                bloques.Add(btn);
                pnJuego.Controls.Add(btn);
            }

            // 3. Actualizar labels
            lblContGatos.Text = $"Contador Bloques: {bloques.Count}";
            lblContPuntos.Text = "Contador Puntuacion: 0";
            lblPuntosTotales.Text = "Puntuación total: 0";

            // 4. Actualizar partidas y puntuaciones
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

        private void clicarBloque(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            romper.Clear();

            int idx = (int)btn.Tag;
            buscarBloques(idx);

            if (romper.Count > 0)
            {
                actualizarBloques();
            }

        }

        public void buscarBloques(int indiceInicial)
        {
            romper.Clear();

            // Si está vacío, terminamos
            if (bloques[indiceInicial] == null)
                return;

            Image objetivo = bloques[indiceInicial].BackgroundImage;

            // Lista donde iremos metiendo los índices pendientes de revisar
            List<int> pendientes = new List<int>();
            pendientes.Add(indiceInicial);

            // Lista de visitados para no repetir
            List<int> visitados = new List<int>();
            visitados.Add(indiceInicial);

            // Mientras haya elementos pendientes...
            while (pendientes.Count > 0)
            {
                int actual = pendientes[0];
                pendientes.RemoveAt(0); // simulación de una queue

                romper.Add(actual);

                // calcular fila y columna
                int fila = actual / 11;
                int col = actual % 11;

                // vecinos: arriba, abajo, izquierda, derecha
                int[] fOff = { -1, 1, 0, 0 };
                int[] cOff = { 0, 0, -1, 1 };

                for (int i = 0; i < 4; i++)
                {
                    int nf = fila + fOff[i];
                    int nc = col + cOff[i];

                    // validar dentro de la matriz
                    if (nf < 0 || nf >= 12 || nc < 0 || nc >= 11)
                        continue;

                    int vecinoIndex = nf * 11 + nc;

                    // Si ya lo vimos, saltamos
                    if (visitados.Contains(vecinoIndex))
                        continue;

                    // Si no tiene bloque, saltamos
                    if (bloques[vecinoIndex] == null)
                        continue;

                    // Si no coincide el color, saltamos
                    if (bloques[vecinoIndex].BackgroundImage != objetivo)
                        continue;

                    // Añadimos para procesar más tarde
                    pendientes.Add(vecinoIndex);
                    visitados.Add(vecinoIndex);
                }
            }

            // Si solo hay 1, es inválido
            if (romper.Count < 2)
                romper.Clear();
        }

        public bool QuedanMovimientos()
        {
            for (int fila = 0; fila < 12; fila++)
            {
                for (int col = 0; col < 11; col++)
                {
                    int idx = fila * 11 + col;
                    Button b = bloques[idx];
                    if (b == null)
                        continue;

                    Image color = b.BackgroundImage;

                    // Vecino de la derecha
                    if (col < 10)
                    {
                        Button vecino = bloques[fila * 11 + (col + 1)];
                        if (vecino != null && vecino.BackgroundImage == color)
                            return true;
                    }

                    // Vecino de abajo
                    if (fila < 11)
                    {
                        Button vecino = bloques[(fila + 1) * 11 + col];
                        if (vecino != null && vecino.BackgroundImage == color)
                            return true;
                    }
                }
            }

            // No se encontró ningún par adyacente del mismo color
            return false;
        }

        private void FinPartida()
        {
            MessageBox.Show("Fin de la partida! Puntuacion: " + puntuacionActual,
                            "Fin de partida", MessageBoxButtons.OK, MessageBoxIcon.Information);

            try
            {
                using(StreamWriter sr = new StreamWriter("estadisticas.txt", existe))
                {
                    //Añadir los datos de las partidas!
                }

            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("No se encuentra el archivo");
            }
            // Guardar puntuación, actualizar estadísticas, reiniciar juego si quieres
            //reiniciarJuego(true);
        }
    }
}
