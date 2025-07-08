using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using debre.Clases;

namespace debre
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Usuarioparacompraenlinea ObjUsuario = new Usuarioparacompraenlinea(1,"09524680304", "Yostin", "Yostin.hidalgo@tecnologicoliceocristiano", "Gigabyte RTX5090","Vergeles-guayaquil", "18285202", "23014738");

            Console.WriteLine("ID: " + ObjUsuario.ID);
            Console.WriteLine("Cedula: " + ObjUsuario.cedula);
            Console.WriteLine("Nombre: " + ObjUsuario.nombredeusuario);
            Console.WriteLine("Correoelectronico: " + ObjUsuario.correoelectronico);
            Console.WriteLine("Producto: " + ObjUsuario.producto);
            Console.WriteLine("Ubicacion: " + ObjUsuario.ubicacion);
            Console.WriteLine("Tarjeta: " + ObjUsuario.getTarjeta());
            Console.WriteLine("Clave: " + ObjUsuario.getclve());
            Console.ReadLine();


            instanciarObjeto();

        }

        private static void instanciarObjeto()
        {
            Console.Clear();
            Console.WriteLine("INGRESE UN NUEVO USUARIO");
            Console.WriteLine();
            Console.Write("Ingrese lel id: ");
            int ID = System.Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Ingrese la cedula: ");
            string cedula = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Ingrese el nombre de usuario: ");
            string nombredeusuario = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Ingrese el Correoelectronico: ");
            string correoelectronico = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Ingrese el Producto: ");
            string producto = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Ingrese el Producto: ");
            string ubicacion = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Ingrese su tarjeta: ");
            string tarjetacomprar = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Ingrese su clave: ");
            string clavedeacceso = Console.ReadLine();
            Console.WriteLine();

            Usuarioparacompraenlinea objetoUsuario = new Usuarioparacompraenlinea(ID,cedula, nombredeusuario, correoelectronico, producto,ubicacion, tarjetacomprar, clavedeacceso);
            Console.WriteLine("La tarjeta de crédito es: " + objetoUsuario.getTarjeta());

            Console.WriteLine("Ingrese la Nueva Tarjeta de Crédito: ");
            tarjetacomprar = Console.ReadLine();

            objetoUsuario.setTarjetaCredito(tarjetacomprar);
            Console.WriteLine("La nueva tarjeta de crédito es: " + objetoUsuario.getTarjeta());

            Console.WriteLine("La clave de acceso es: " + objetoUsuario.getclve());

            Console.WriteLine("Ingrese la Nueva Clave de acceso: ");
            tarjetacomprar = Console.ReadLine();

            objetoUsuario.setTarjetaCredito(tarjetacomprar);
            Console.WriteLine("La nueva Clave de acceso: " + objetoUsuario.getclve());
        }
    }
}