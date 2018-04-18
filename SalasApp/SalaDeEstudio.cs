using System;
using System.Collections.Generic;
using System.Text;

namespace SalasApp
{
    class SalaDeEstudio: Salas
    {
        public SalaDeEstudio(List<string> equipamiento, List<string> horario, string codigo)
            : base(equipamiento, horario, codigo)
        {

        }
    }
}
