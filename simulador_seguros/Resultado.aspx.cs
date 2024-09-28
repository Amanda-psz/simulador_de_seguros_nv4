using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace simulador_seguros
{
    public partial class Resultado : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["valorSeguro"] != null)
            {
                string valorSeguroStr = Request.QueryString["valorSeguro"];

                // Validar se o valor é numérico
                if (double.TryParse(valorSeguroStr, out double valorSeguro))
                {
                    // Formatar o valor como moeda
                    string valorFormatado = valorSeguro.ToString("C", CultureInfo.GetCultureInfo("pt-BR")); // Adapte a cultura para o seu país

                    LabelResultado.Text = $"O valor do seguro escolhido é: {valorFormatado}";
                }
                else
                {
                    LabelResultado.Text = "O valor informado não é válido.";
                }
            }
            else
            {
                LabelResultado.Text = "Não foi possível calcular o valor do seguro.";
            }
        }
    }
}