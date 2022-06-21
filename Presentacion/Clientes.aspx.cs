using RestSharp;
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


            //int id = 1;
            //string nombre  = "lo que sea ";
            //string apellido  = "lo que sea ";

            string responseBody = string.Empty;
            var url = $"https://localhost:44329/api/Peticion?peticion=pruebas";
            var request = (HttpWebRequest)WebRequest.Create(url);
            //string json = $"{{\"Id\":\"{id}\",\"Nombre\":\"{nombre}\",\"Apellido\":\"{apellido}\"}}";
            request.Method = "POST";
            request.ContentType = "application/json";
            request.Accept = "application/json";
            //using (var streamWriter = new StreamWriter(request.GetRequestStream()))
            //{
            //    streamWriter.Write(json);
            //    streamWriter.Flush();
            //    streamWriter.Close();
            //}
            try
            {
                using (WebResponse response = request.GetResponse())
                {
                    using (Stream strReader = response.GetResponseStream())
                    {
                        using (StreamReader objReader = new StreamReader(strReader))
                        {
                            responseBody = objReader.ReadToEnd();
                            // Do something with responseBody
                        }
                    }
                }
            }
            catch (WebException ex)
            {
                // Handle error
            }


            return  responseBody;

        }

    }
}