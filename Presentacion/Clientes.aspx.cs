using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Presentacion
{
    public partial class Clientes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!Page.IsPostBack)
                {
                    PeticionCrearCliente();

                }

                else
                {

                }

            }
            catch (Exception ex)
            {

                throw;
            }
        }

        private string PeticionCrearCliente()
        {
            var url = $"https://localhost:44329/api/Cliente";
            var request = (HttpWebRequest)WebRequest.Create(url);
            string responseBody = string.Empty;
            request.Method = "GET";
            request.ContentType = "application/json";
            request.Accept = "application/json";
            try
            {
                using (WebResponse response = request.GetResponse())
                {
                    using (Stream strReader = response.GetResponseStream())
                    {
                        using (StreamReader objReader = new StreamReader(strReader))
                        {
                            responseBody = objReader.ReadToEnd();
                        }
                    }
                }
            }
            catch (WebException ex)
            {
                // Handle error
            }

            return responseBody;

        }




    }
}