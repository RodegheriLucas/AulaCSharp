using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulasPOO.uteis
{

    public class Sorteador
    {
        public List<string> Sorter(List<string> Nome)
        {
            Random Rand = new Random();
            List<string> sorted = [];
            for (int i = 0; i <= (Nome.Count/2); i++)
            {
                int RandInd = Rand.Next(Nome.Count);
                sorted.Add(Nome[RandInd]);
            }
            return sorted;
        }
    }
}
