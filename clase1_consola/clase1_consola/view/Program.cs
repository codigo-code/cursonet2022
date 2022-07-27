using System;
using clase1_consola.controller;
using clase1_consola.model;

namespace clase1_consola.view
{
    class Program
    {
        static void Main(string[] args)
        {
            UserController uc = new UserController();

            Console.WriteLine("Por favor ingrese el nombre de usuario");
            string username = Console.ReadLine();

            Console.WriteLine("Por favor ingrese el password");
            string password = Console.ReadLine();

            User u = new User();

            u.username = username;
            u.password = password;


            Console.WriteLine(uc.saveUser(u));

            Console.WriteLine("=====================");

            Console.WriteLine("ingrese el username");

            string user = Console.ReadLine();

            Console.WriteLine("ingrese el password");

            string pass = Console.ReadLine();

            // reutilizo el objeto u ---> e instancion nuevamente el objeto 
            u = new User();


            u.username = user;
            u.password = pass;

            if (uc.checkUser(u))
            {
                Console.WriteLine("Access success");
            }
            else
            {
                Console.WriteLine("Access Denied");
            }
            Console.WriteLine("==========MUESTRO TODOS LOS USUARIOS===========");
            foreach (var item in uc.showAllUser())
            {
                Console.WriteLine( "User: " +item.username + ", Pass:" + item.password);
            }

            Console.WriteLine("Fin del programa");
        }
    }
}

