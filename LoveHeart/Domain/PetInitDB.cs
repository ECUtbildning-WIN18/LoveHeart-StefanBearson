﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoveHeart.Domain
{
    class PetInitDB
    {
        public static void addingPetsToOwners()
        {
            Pet p1 = new Pet("Fiddo", "Fidde", "Dog", new DateTime(2018-01-01));
            Pet p2 = new Pet("Freaky", "Crazy mother f%¤#er", "Dog", new DateTime(2018 - 01 - 01));
            Pet p3 = new Pet("Piller", "Bengt-Göran", "Cat", new DateTime(2018 - 01 - 01));
            Pet p4 = new Pet("Kissen", "Pjurre", "Cat", new DateTime(2018 - 01 - 01));
            Pet p5 = new Pet("Ludde", "Ludde", "Dinasure", new DateTime(2018 - 01 - 01));

            p1.Notes.Add("Testar1");
            p1.Notes.Add("Testar 2");

            Program.customers["470101-1234"].OwnerAnimals.Add(p1);
            Program.customers["470101-1234"].OwnerAnimals.Add(p2);
            Program.customers["990101-5123"].OwnerAnimals.Add(p3);
            Program.customers["220101-6532"].OwnerAnimals.Add(p4);
            Program.customers["360101-1464"].OwnerAnimals.Add(p5);
        }
    }
}
