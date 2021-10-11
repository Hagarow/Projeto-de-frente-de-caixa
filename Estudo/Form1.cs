using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Estudo
{
    public partial class frenteCaixa : Form
    {
        string[] codProd = new string[6];
        string[] nomeProd = new string[6];
        decimal[] valorProd = new decimal[6];
        decimal somaTotal;
        public frenteCaixa()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadPoducts();
            somaTotal = 0;
        }
        private void loadPoducts()
        {

            codProd[1] = "12345";
            codProd[2] = "12346";
            codProd[3] = "12347";
            codProd[4] = "12348";
            codProd[5] = "12349";

            nomeProd[1] = "Filtro de ar Gol G5";
            nomeProd[2] = "Filtro de gasolina Gol G5";
            nomeProd[3] = "Filtro de olho Gol G5";
            nomeProd[4] = "Jogo de cabo de vela Gol 2009 diant";
            nomeProd[5] = "Jogo de vela Gol 2009";

            valorProd[1] = 20.61m;
            valorProd[2] = 25m;
            valorProd[3] = 29.83m;
            valorProd[4] = 155.35m;
            valorProd[5] = 121.23m;
        }

        private void tbcodigo_TextChanged(object sender, EventArgs e)
        {
            if (tbcodigo.Text.Length == 5)
            {
                int ind = 0;
                for (int cp =1; cp < 6; cp++)
                {
                    if(tbcodigo.Text == codProd[cp])
                    {
                        ind = cp;
                    }
                }
                if(ind > 0)
                {
                    listProd.Items.Add(string.Format("#{0} - {1} - {2}",codProd[ind], nomeProd[ind], valorProd[ind]));
                    somaTotal += valorProd[ind];
                    tbtotal.Text = Convert.ToString(somaTotal);
                }
                else
                {
                    MessageBox.Show("Produto não encontrado");
                }
            }
            
        }
    }
}
