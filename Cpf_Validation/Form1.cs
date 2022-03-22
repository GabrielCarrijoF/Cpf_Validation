using System;
using System.Windows.Forms;

namespace Cpf_Validation
{


    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public bool isCpf(String cpf)
        {

            string tempCpf =  null;
            string digito = null;
            int soma = 0;
            int resto = 0;
            int[] multResultV1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multResultV2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };


            cpf.Trim();
            cpf.Replace(",", "").Replace("-", "");

            tempCpf = cpf.Substring(0, 9);

            for (int i = 0; i < 9; i++)
            {
                soma += int.Parse(tempCpf[i].ToString()) * multResultV1[i];
            }
            resto = soma % 11;
            if (resto < 2)
            {
                soma = 0;
            }
            else
            {
                resto = 11 - soma;
            }
            digito = resto.ToString();

            tempCpf = tempCpf + digito;


            for (int i = 0; i < 9; i++)
            {
                soma += int.Parse(tempCpf[i].ToString()) * multResultV2[i];
            }
            resto = soma % 11;
            if (resto < 2)
            {
                soma = 0;
            }
            else
            {
                resto = 11 - soma;
            }
            digito = resto.ToString();

            tempCpf = tempCpf + digito;

            return cpf.EndsWith(digito);
        }

        public void button1_Click(object sender, EventArgs e)
        {


            if (isCpf(maskedCpf1.Text = "12345678911"))
            {
                MessageBox.Show("CPF Inválido!");
            }
            else
            {
                MessageBox.Show("CPF Válido!");
            }
        }

    }

}