using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoveHeart.Domain
{
    class VetInitDB
    {
        public static void AddVets()
        {
            Program.vets.Add(new Vet("0001", "Calle", "Göransson"));
            Program.vets.Add(new Vet("0002", "Molle", "Bengtsson"));
        }
    }
}
