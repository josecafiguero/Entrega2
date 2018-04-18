using System;
using System.Collections.Generic;

namespace SalasApp
{
    class Program
    {
        public static List<Usuario> usuarios;
        public static Usuario loggedIn;
        static void Main(string[] args)
        {
            usuarios = new List<Usuario>();
            Console.WriteLine("Ingreso o Registro:");
            //I sería la variable que almacena si la persona está ingresando o registrandose.
            var I = Console.ReadLine();//variable string I puede ser o ingreso o registro 
            if (I == "ingreso")
            {
                Console.WriteLine("ingrese su nombre ");
                String name = Console.ReadLine();
                Console.WriteLine("ingrese su clave: ");
                String clave = Console.ReadLine();

                for (int i = 0; i < usuarios.Count; i++)
                {
                    if (usuarios[i].Nombre == name && usuarios[i].Contraseña == clave)
                    {
                        loggedIn = usuarios[i];
                        Console.Clear();
                        break;
                    }
                }                
                               
            }
            while (I == "Registro")//arreglar los usuarios para que tome más de 1 

            {
                Console.WriteLine("Estudiante, Profesor o Bibliotecario");
                var a = Console.ReadLine();//variable string que nos dirá si que tipo de usuario se estará registrando
                if( a=="Estudiante")
                {
                    Estudiante estudiante = new Estudiante();
                    Console.WriteLine("ingrese su nombre ");//aquí se crearía el nombre de usuario del estudiante                    
                    estudiante.Nombre = Console.ReadLine();
                    Console.WriteLine("ingrese su rut");
                    estudiante.Rut = Console.ReadLine();
                    Console.WriteLine("ingrese su contraseña");
                    estudiante.Contraseña = Console.ReadLine();
                    Console.WriteLine("ingrese su mail");
                    estudiante.Mail = Console.ReadLine();
                    estudiante.Estado = "habil";
                    estudiante.Puntaje = 10;
                    usuarios.Add(estudiante);
                    break;
                }
                else if (a == "profesor")
                {
                    Profesor profesor = new Profesor();
                    Console.WriteLine("ingrese su nombre ");//aquí se crearía el nombre de usuario del profesor               
                    profesor.Nombre = Console.ReadLine();
                    Console.WriteLine("ingrese su rut");
                    profesor.Rut = Console.ReadLine();
                    Console.WriteLine("ingrese su contraseña");
                    profesor.Contraseña = Console.ReadLine();
                    Console.WriteLine("ingrese su mail");
                    profesor.Mail = Console.ReadLine();
                    usuarios.Add(profesor);
                    break;

                }
                else if (a == "bibliotecario")
                {
                    Bibliotecario bibliotecario = new Bibliotecario();
                    Console.WriteLine("ingrese su nombre ");//aquí se crearía el nombre de usuario del Bibliotecario             
                    bibliotecario.Nombre = Console.ReadLine();
                    Console.WriteLine("ingrese su rut");
                    bibliotecario.Rut = Console.ReadLine();
                    Console.WriteLine("ingrese su contraseña");
                    bibliotecario.Contraseña = Console.ReadLine();
                    Console.WriteLine("ingrese su mail");
                    bibliotecario.Mail = Console.ReadLine();
                    bibliotecario.Horario = "horario";
                    usuarios.Add(bibliotecario);
                    break; 

                }
                
            }               
            
                        
        }
    }
}
