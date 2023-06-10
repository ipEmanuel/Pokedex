using dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using negocio;
using Negocio;

namespace pokedex_web
{
    public partial class LoginEjemplo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegistrarse_Click(object sender, EventArgs e)
        {
            try
            {
                Trainee user = new Trainee();
                TraineeNegocio traineeNegocio = new TraineeNegocio();
                EmailService emailService = new EmailService(); 
                user.Email = txtEmail.Text;
                user.Pass = txtPassword.Text;
                int id = traineeNegocio.insertarNuevo(user);
                emailService.armarCorreo(user.Email,"Hola bienvenido","Suuuppeeerrr");
                emailService.enviarEmail();
                Response.Redirect("Default.aspx");

            }
            catch (Exception ex)
            {

                Session.Add("Error", ex.ToString());
            }
        }
    }
}