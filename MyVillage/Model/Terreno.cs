using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyVillage.Model
{
    internal class Terreno
    {
        public double TamanhoDoTerreno { get; set; } = 0;
        public decimal Price { get; set; }

        public override string ToString()
        {
            if (TamanhoDoTerreno != 0)
            {
                return $"\nTamanho do Terreno: {TamanhoDoTerreno}";
            }
            return "\nTamanho do Terreno não identificado";
            
        }
    }
}
