using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3C2VITORGABRIEL50
{
    public partial class frmprincipal : Form
    {
        public frmprincipal()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            FolhaDePagamento objFolhadePagamento = new FolhaDePagamento();

            double salariobruto = 0, descontoINSS = 0, descontoValeTransporte = 0, salarioliquido = 0;

            if(!double.TryParse(txtsalario.Text, out salariobruto))
            {
                MessageBox.Show("Valor de salário inválido");
            }
            else
            {
                salariobruto = double.Parse(txtsalario.Text);

                descontoINSS = objFolhadePagamento.calculoINSS(salariobruto);
                descontoValeTransporte = objFolhadePagamento.valeTransporte(salariobruto);
                salarioliquido = objFolhadePagamento.salarioLiquido(descontoValeTransporte, descontoINSS, salariobruto);

                lblsalariobruto.Text = salariobruto.ToString("C");
                lblsalarioliquido.Text = salarioliquido.ToString("C");
                lblinss.Text = descontoINSS.ToString("C");
                lblvaletransporte.Text = descontoValeTransporte.ToString("C");
            }


            txtsalario.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            rdb40horas.Checked = false;
            rdb44horas.Checked = false;
        }
    }
}
