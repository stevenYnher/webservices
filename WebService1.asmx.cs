using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace webservices
{
 
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {

        [WebMethod]
        public string QuienEres(string nombre)
        {
            return "Hola "+nombre;
        }
    [WebMethod]
        public string Calculadora(int primervalor,int segundovalor,string operacion)
         {
            float result = 0;
            switch (operacion)
            {
                case "+":result = primervalor + segundovalor;
                    break;
                case "-":result = primervalor - segundovalor;
                    break;
                case "*":result = primervalor*segundovalor;
                    break;
                case "/":result = primervalor / segundovalor;
                    break;
            }
            return result.ToString();
         }
    }
}
