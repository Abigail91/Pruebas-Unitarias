using System;

namespace Investigacion1
{
    public class Program
    {
        static void Main(string[] args)
        {

        }

        //Metodo para la verificación de un User y Password
        //Esta hecho con valores fijos para efectos del ejemplo, pues en este aspecto tendría que existir una Base de Datos conectada
        //para hacer la verificacion con los datos que se encontrarian en ella
        public static bool Login(string user, string password) =>
            //Si es User y el Password coinciden, devuelve True, de lo contrario devuelve False 
            user == "pazofeifa" && password == "123456" ? true : false; 
    }
}
