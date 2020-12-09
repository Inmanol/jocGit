using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormMDI
{
    public partial class FrmPedraPaperTisora : Form
    {
        public event EventHandler emTanquen;
        string[] opcionsIA = { "pedra", "paper", "tisora", "pedra", "tisora", "paper" };
        public int numeroAleatori;
        Random R = new Random();
        string opcioIA;
        string opcioJugador;

        public FrmPedraPaperTisora()
        {
            InitializeComponent();
            opcioJugador = "none";
        }

        private void FrmPedraPaperTisora_FormClosing(object sender, FormClosingEventArgs e)
        {
            emTanquen(this, EventArgs.Empty);
        }

        private void comprovarJoc()
        {
            if (opcioJugador == "pedra" && opcioIA == "paper") MessageBox.Show("La IA guanya");
            else if (opcioJugador == "paper" && opcioIA == "pedra") MessageBox.Show("El jugador guanya");
            else if (opcioJugador == "paper" && opcioIA == "tisora") MessageBox.Show("La IA guanya");
            else if (opcioJugador == "tisora" && opcioIA == "paper") MessageBox.Show("El jugador guanya");
            else if (opcioJugador == "tisora" && opcioIA == "pedra") MessageBox.Show("La IA guanya");
            else if (opcioJugador == "pedra" && opcioIA == "tisora") MessageBox.Show("El jugador guanya");
            else MessageBox.Show("Empat");
            
        }

        private void btnPedra_Click(object sender, EventArgs e)
        {
            opcioJugador = "pedra";
            pbJugador.Image = Properties.Resources.rock;
            comprovarIA();
            comprovarJoc();
        }

        private void btnPaper_Click(object sender, EventArgs e)
        {
            opcioJugador = "paper";
            pbJugador.Image = Properties.Resources.paper;
            comprovarIA();
            comprovarJoc();
        }

        private void btnTisora_Click(object sender, EventArgs e)
        {
            opcioJugador = "tisora";
            pbJugador.Image = Properties.Resources.scissors;
            comprovarIA();
            comprovarJoc();
        }

        private void comprovarIA()
        {
            numeroAleatori = R.Next(0, 5);
            opcioIA = opcionsIA[numeroAleatori];

            switch (opcioIA)
            {
                case "pedra": pbIA.Image = Properties.Resources.rock;
                    break;
                case "paper": pbIA.Image = Properties.Resources.paper;
                    break;
                case "tisora": pbIA.Image = Properties.Resources.scissors;
                    break;
            }
        }
    }
}
