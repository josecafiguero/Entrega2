using System;
using System.Collections.Generic;
using System.Text;

namespace SalasApp
{
    class Salas
    {
        List<string> Equipamiento;
        List<string> Horario;
        string Codigo;
        public Salas(List<string>equipamiento, List<string> horario, string codigo)
        {
            Equipamiento = equipamiento;
            Horario = horario;
            Codigo = codigo;
                        
        }
    }
}
