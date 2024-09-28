using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace simulador_seguros
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        // Método para calcular o valor do seguro
        protected decimal CalculandoValorSeguro(int idade, string tipoSeguro)
        {
            decimal valorReferencia = 1000m; //Valor de referência em decimal

            switch (tipoSeguro)
            {
                case "Seguro de vida":
                    valorReferencia *= 0.8m;
                    break;
                case "Seguro de morte acidental":
                    valorReferencia *= 0.9m;
                    break;
                case "Seguro contra acidentes pessoais":
                    valorReferencia *= 0.5m;
                    break;
                case "Seguro de saúde":
                    valorReferencia *= 0.4m;
                    break;
                case "Seguro de automóvel":
                    valorReferencia *= 2.5m;
                    break;
                case "Seguro residencial":
                    valorReferencia *= 0.6m;
                    break;
                case "Seguro patrimonial":
                    valorReferencia *= 1.2m;
                    break;
                case "Seguro empresarial":
                    valorReferencia *= 1.5m;
                    break;
                default:
                    break;
            }

            return valorReferencia;
        }

        // Método para calcular e exibir o resultado quando o botão for clicado
        protected void Enviar_dados(object sender, EventArgs e)
        {
            //Pega os dados do formulário
            string nome = Nome.Text;
            DateTime dataNascimento;
            bool dataValida = DateTime.TryParse(Data_nascimento.Text, out dataNascimento);

            if (!dataValida)
            {
                ResultadoLabel.Text = "Data de nascimento inválida";
                return;
            }

            // Cálculo da idade
            int idade = DateTime.Now.Year - dataNascimento.Year;
            if (dataNascimento > DateTime.Now.AddYears(-idade)) idade--;

            string tipoSeguro = RadioButtonList_seguros.SelectedValue; //Pega o tipo de sguro na lista

            if (string.IsNullOrEmpty(tipoSeguro))
            {
                ResultadoLabel.Text = "É necessario selecionar um tipo de seguro.";
                return;
            }

            decimal valorSeguro = CalculandoValorSeguro(idade, tipoSeguro); //Função que calcula o valor do seguro atribuida a uma variavel

            //Redireciona para a página Resultado
            Response.Redirect($"O valor estimado do seu seguro é: R$ {valorSeguro:F2}");
        }
    }
}
