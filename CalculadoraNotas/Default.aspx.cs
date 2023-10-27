using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CalculadoraNotas
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
          
        }

        protected void btnNotas_Click(object sender, EventArgs e)
        {
            float Nota1 = float.Parse(txtNota1.Text);
            float Nota2 = float.Parse(txtNota2.Text);
            float Nota3 = float.Parse(txtNota3.Text);
            lblResultado.Text = ((Nota1 + Nota2 + Nota3) / 3).ToString();
        }
    }
}