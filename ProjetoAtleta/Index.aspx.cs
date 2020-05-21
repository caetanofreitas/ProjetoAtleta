using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjetoAtleta
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_Calc_Click(object sender, EventArgs e)
        {
            Atleta obj = new Atleta();
            try
            {
                lbl_Error.Visible = false;
                lbl_Error.Text = "";
                lbl_Resultado.Text = "";
                lbl_Resultado.Visible = false;
                obj.Nome = txt_Nome.Text;
                obj.Peso = double.Parse(txt_Peso.Text);
                obj.Altura = double.Parse(txt_Altura.Text);
                obj.Idade = int.Parse(txt_Idade.Text);

                lbl_Resultado.Text = "IMC:" + obj.CalcularIMC().ToString();
                lbl_Resultado.Visible = true;
            }
            catch (Exception ex) {
                lbl_Error.Visible = true;
                lbl_Error.Text = ex.Message;
            }
        }
    }
}