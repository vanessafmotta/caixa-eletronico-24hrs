using System;
using System.Windows.Forms;

namespace CaixaEletronico
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void Limpar()
        {
            boxNt100.Clear();
            boxNt50.Clear();
            boxNt20.Clear();
            boxNt10.Clear();
            boxNt5.Clear();
            boxNt2.Clear();
        }

        public void btnEnviar_Click(object sender, EventArgs e)
        {
            Limpar();

            int nt2;
            int valor = Convert.ToInt32(txtValor.Text);

            if (valor == 0)
            {
                Environment.Exit(0);
            }

            if (valor % 2 != 0)
            {
                int ntq2 = 0, ntq5=0;

                valor = valor - 5;
                ntq5 = 1;

                valor = valor - 4;
                ntq2 = 2;

                int nt100 = valor / 100;
                int sobra = valor - (nt100 * 100);
                if (nt100 != 0)
                { boxNt100.Text = Convert.ToString(nt100); }

                int nt50 = sobra / 50;
                sobra = sobra - (nt50 * 50);
                if (nt50 != 0)
                { boxNt50.Text = Convert.ToString(nt50); }

                int nt20 = sobra / 20;
                sobra = sobra - (nt20 * 20);
                if (nt20 != 0)
                { boxNt20.Text = Convert.ToString(nt20); }

                int nt10 = sobra / 10;
                sobra = sobra - (nt10 * 10);
                if (nt10 != 0)
                { boxNt10.Text = Convert.ToString(nt10); }

                int nt5 = sobra / 5;
                sobra = sobra - (nt5 * 5);
                nt5 = nt5 + ntq5;
                if (nt5 != 0)
                { boxNt5.Text = Convert.ToString(nt5); }

                nt2 = sobra / 2;
                sobra = sobra - (nt2 * 2);
                nt2 = nt2 + ntq2;
                if (nt2 != 0)
                { boxNt2.Text = Convert.ToString(nt2); }
            }

            else
            {
                int nt100 = valor / 100;
                int sobra = valor - (nt100 * 100);
                if (nt100 != 0)
                { boxNt100.Text = Convert.ToString(nt100); }

                int nt50 = sobra / 50;
                sobra = sobra - (nt50 * 50);
                if (nt50 != 0)
                { boxNt50.Text = Convert.ToString(nt50); }

                int nt20 = sobra / 20;
                sobra = sobra - (nt20 * 20);
                if (nt20 != 0)
                { boxNt20.Text = Convert.ToString(nt20); }

                int nt10 = sobra / 10;
                sobra = sobra - (nt10 * 10);
                if (nt10 != 0)
                { boxNt10.Text = Convert.ToString(nt10); }

                //int nt5 = sobra / 5;
                //sobra = sobra - (nt5 * 5);
                //if (nt5 != 0)
                //{ boxNt5.Text = Convert.ToString(nt5); }

                nt2 = sobra / 2;
                sobra = sobra - (nt2 * 2);
                //nt2 = nt2 + ntq2;
                if (nt2 != 0)
                { boxNt2.Text = Convert.ToString(nt2); }

            }

            lblValorSol.Text = Convert.ToString(txtValor.Text) + ",00";
        }
    }
}