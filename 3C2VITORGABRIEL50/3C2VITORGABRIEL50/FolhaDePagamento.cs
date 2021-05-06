using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3C2VITORGABRIEL50
{
    class FolhaDePagamento
    {

        public double calculoINSS(double salarioBruto)
        {
            double descontoINSS = 0;

            if (salarioBruto <= 1100.00)
            {
                descontoINSS = salarioBruto * 0.075;
            }
            else if (salarioBruto >= 1100.01 && salarioBruto <= 2203.48)
            {
                descontoINSS = salarioBruto * 0.09;
            }
            else if (salarioBruto >= 2203.49 && salarioBruto <= 3305.22)
            {
                descontoINSS = salarioBruto * 0.12;
            }
            else if (salarioBruto >= 3305.23 && salarioBruto <= 6433.57)
            {
                descontoINSS = salarioBruto * 0.14;
            }

            return descontoINSS;
        }

        public double valeTransporte(double salarioBruto)
        {
            double descontoValeTransporte = 0;

            descontoValeTransporte = salarioBruto * 0.06;

            if (descontoValeTransporte > 120.00)
            {
                descontoValeTransporte = 120.00;
            }

            return descontoValeTransporte;
        }

        public double salarioLiquido(double descontoValeTransporte, double descontoINSS, double salarioBruto)
        {
            double salario = salarioBruto - descontoValeTransporte - descontoINSS;

            return salario;
        }
    }
}
