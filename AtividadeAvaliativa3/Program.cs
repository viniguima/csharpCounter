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
            contadorCliques++;
            AtualizarContadorCliques();
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
