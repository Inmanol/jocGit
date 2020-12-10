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
    public partial class FrmPenjat : Form
    {
        GeneradorPalabras palabra = new GeneradorPalabras();

        int cont 7;
        String palabraGenerada = palabra.SiguientePalabra;
        StringBuilder adivinar = new StringBuilder(palabraGenerada);
        public event EventHandler emTanquen;
        public FrmPenjat()
        {
            InitializeComponent();
        }

        private void FrmPenjat_FormClosing(object sender, FormClosingEventArgs e)
        {
            emTanquen(this, EventArgs.Empty);
        }

        private void FrmPenjat_Load(object sender, EventArgs e)
        {

        }

        private void qttLletres()
        {
            int longitud = palabraGenerada.Length;
            longitud = longitud / 2;

            palabraGenerada.ToCharArray();


            for (int i = 0; i < palabraGenerada.Length; i++)
            {
                if (i == longitud || i == palabraGenerada.Length - 1)
                {
                    adivinar[i] = palabraGenerada[i];
                }
                else
                {
                    adivinar[i] = '_';
                }

            }
        }
        private void gana()
        {
            while (cont > 0)
            {
                Console.WriteLine("Dame una letra");
                char letra = Convert.ToChar(Console.ReadLine());
                bool esIgual = false;

                for (int i = 0; i < palabraGenerada.Length; i++)
                {
                    if (letra == palabraGenerada[i])
                    {
                        adivinar[i] = letra;
                        esIgual = true;
                    }
                }

                if (esIgual)
                {
                    Console.WriteLine("Has acertado!");
                    for (int i = 0; i < palabraGenerada.Length; i++)
                    {
                        Console.Write(" {0}", adivinar[i]);
                    }
                    Console.WriteLine("");
                    Console.WriteLine("");
                }
                else
                {
                    Console.WriteLine("No has acertado");
                    cont--;
                }

                bool terminoElJuego = true;
                for (int i = 0; i < palabraGenerada.Length; i++)
                {
                    if (adivinar[i] == '_')
                    {
                        terminoElJuego = false;
                    }
                }

                if (terminoElJuego)
                {
                    Console.WriteLine("GANASTE!!");
                    break;

                }

            }
        }

        
    }
}
