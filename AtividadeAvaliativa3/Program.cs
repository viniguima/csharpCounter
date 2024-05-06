using System;
using System.Windows.Forms;

namespace ContadorCliques
{
    static class Program
    {

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormContadorCliques());
        }
    }

    public partial class FormContadorCliques : Form
    {
        private int contadorCliques = 0;

        public FormContadorCliques()
        {
            InitializeComponent();
            AtualizarContadorCliques();
        }

        private void AtualizarContadorCliques()
        {
            labelContador.Text = "Número de cliques: " + contadorCliques;
        }

        private void btnMais_Click(object sender, EventArgs e)
        {
            if (contadorCliques < 10)
            {
                contadorCliques++;
                AtualizarContadorCliques();

                if (contadorCliques == 7)
                {
                    MessageBox.Show("Faltam apenas mais 3");
                }
                else if (contadorCliques == 8)
                {
                    MessageBox.Show("Faltam apenas mais 2");
                }
                else if (contadorCliques == 9)
                {
                    MessageBox.Show("Falta apenas mais 1");
                }
                else if (contadorCliques == 10)
                {
                    MessageBox.Show("Acabou !");
                }
            }
            else
            {
                MessageBox.Show("Já atingiu o máximo de 10 contagens.");
            }
        }


        private void btnMenos_Click(object sender, EventArgs e)
        {
            if (contadorCliques > 0)
            {
                contadorCliques--;
                AtualizarContadorCliques();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            contadorCliques = 0;
            AtualizarContadorCliques();
        }
    }
}
