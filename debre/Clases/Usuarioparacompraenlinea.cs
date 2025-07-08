using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace debre.Clases
{
    public class Usuarioparacompraenlinea
    {
        public int ID;
        public string cedula;
        public string nombredeusuario;
        public string correoelectronico;
        public string producto;
        public string ubicacion;
        private string tarjetacomprar;
        private string clavedeacceso;

        public Usuarioparacompraenlinea(int iD, string cedula, string nombredeusuario, string correoelectronico, string producto, string ubicacion, string tarjetacomprar, string clavedeacceso)
        {
            ID = iD;
            this.cedula = cedula;
            this.nombredeusuario = nombredeusuario;
            this.correoelectronico = correoelectronico;
            this.producto = producto;
            this.ubicacion = ubicacion;
            this.tarjetacomprar = tarjetacomprar;
            this.clavedeacceso = clavedeacceso;
        }
        public string getTarjeta()
        {
            int cantidadCaracteres = this.tarjetacomprar.Length;

            string retornoTarjetaCredito = this.tarjetacomprar.Replace(tarjetacomprar.Substring(0, cantidadCaracteres - 4), "");

            return retornoTarjetaCredito;

        }

        public void setTarjetaCredito(string numeroTarjetaCredito)
        {
            Console.WriteLine("Ingrese la clave de acceso: ");
            string clavedeacceso = Console.ReadLine();
            if (clavedeacceso == this.clavedeacceso)
            {
                this.tarjetacomprar = numeroTarjetaCredito;
            }
            else
            {
                Console.WriteLine("Clave incorrecta, no tiene acceso a la tarjeta");
            }
            }
             public string getclve()
        {
            int cantidadCaracteres = this.tarjetacomprar.Length;

            string retornoTarjetaCredito = this.tarjetacomprar.Replace(tarjetacomprar.Substring(0, cantidadCaracteres - 4), "");

            return retornoTarjetaCredito;

        }

        public void setclave(string numeroTarjetaCredito)
        {
            Console.WriteLine("Ingrese la cedula: ");
            string cedulaIngresada = Console.ReadLine();
            if (cedulaIngresada == this.cedula)
            {
                this.tarjetacomprar = numeroTarjetaCredito;
            }
            else
            {
                Console.WriteLine("Cedula incorrecta, no tiene acceso a la tarjeta");
            }
        }
    }
}