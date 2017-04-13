using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsumirWebService
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var joca = 0;
                string xmlDoc = System.IO.File.ReadAllText(@"D:\Pruebas\pagos.xml");
                //string xmlDoc = System.IO.File.ReadAllText(@"G:\Proyectos\PEZTALOZZI\pruebas\PruebaFR\kenyi\22032017\entregas.xml");
                Console.Write("Archivo Cargado");
                svSAP.WS_SB1SoapClient wsSap = new svSAP.WS_SB1SoapClient();
                Console.Write("Conectando al webervice");
                string respuesta = wsSap.CrearDocumentoPagoVentas(xmlDoc);
                //sSap.CrearDocumentoEntrega(xmlDoc);
                Console.Write(respuesta);
                Console.Read();
            }
            catch (Exception ex)
            {

                throw;
            }
           

        }
    }
}
