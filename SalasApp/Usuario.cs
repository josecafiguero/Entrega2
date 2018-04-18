using System;
using System.Collections.Generic;
using System.Text;

namespace SalasApp
{
    public abstract class Usuario
    {
        public string Nombre { get; set; }
        public string Rut { get; set; }
        public string Contraseña { get; set; }
        public string Mail { get; set; }


        public string GetRut(string[] args)
        {
            return Rut;

        }
    }
}
