using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introducao_CSharp
{
    public class Forma : ReceitaBolo
    {
        public void preparaBolo(ReceitaBolo bolo)
        {
            var sabor = bolo.setSabor();
            bolo.Trigo = 500;
            Leite = 1;
            bolo.setOvo(6);

            Console.WriteLine($"O seu bolo precisa de {bolo.Trigo} gramas de Trigo");
            Console.WriteLine($"O seu bolo precisa de {Leite} litro(s) de Leite");
            Console.WriteLine($"O seu bolo precisa de {bolo.Ovo} Ovo(s)");
            Console.WriteLine($"O seu bolo precisa de {bolo.Manteiga} gramas de Manteiga");
            Console.WriteLine($"O sabor do seu bolo é: {sabor}");
        }
    }
}
