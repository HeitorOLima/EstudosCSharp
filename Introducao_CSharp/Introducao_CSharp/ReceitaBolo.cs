using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introducao_CSharp
{
     public abstract class ReceitaBolo
    { 

        public int Trigo { get; set; }
        public int Ovo { get; set; }
        public int Leite { get; set; }
        public int Manteiga { get; set; }

        public void setOvo(int quantidadeOvos)
        {
            this.Ovo = quantidadeOvos;
        }

        public virtual string setSabor()
        {
            Console.WriteLine("Chamou Aqui");
            return this.setSabor();
        }

    }
}
