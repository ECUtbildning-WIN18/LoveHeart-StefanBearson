using System;
using System.Collections.Generic;

namespace LoveHeart.Domain
{
    class Pet
    {
        public List<string> Notes = new List<string>();

        public string Name { get; set; }
        public string NickName { get; set; }
        public string TypeOfAnimal { get; set; }
        public DateTime Birthday { get; set; }

        public Pet(string name, string nickName, string typeOfAnimal)
        {
            Name = name;
            NickName = nickName;
            TypeOfAnimal = typeOfAnimal;

        }
    }
}
