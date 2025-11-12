using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JawBreaker_
{
    public partial class Ayuda : Form
    {
        public Ayuda()
        {
            InitializeComponent();

            lblAyuda.MaximumSize = new Size(plAyuda.Width-20, 0);

            lblAyuda.Text = $"Sección de ayuda de KitBreaker!{Environment.NewLine}{Environment.NewLine} En este juego tendrás que tratar de quedarte sin gatos en la pantalla clicando donde haya al menos 2 de ellos juntos, el juego termina o cuando se eliminan todos los gatos o cuando el jugador termina sin poder realizar ningún movimineto más.{Environment.NewLine} El juego acumula puntos a medida que se van eliminando los gatos en pantalla, guarda también un historial de partidas jugadas y de puntuaciones que se puede ver en la interfaz principal";
        }

        private void ratonEnBoton(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            btn.BackColor = Color.Pink;
        }

        private void ratonFueraDeBoton(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            btn.BackColor = Color.White;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
