using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introducao_CSharp
{
    public class BoloMorango : ReceitaBolo
    {
        public BoloMorango()
        {
        }

        public string Sabor {get; set;}
        public string Morango { get; set; }

        public override string setSabor()
        {
            this.Sabor = "Morango";

            return Sabor;
        }
    }
}
