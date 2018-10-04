using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoveHeart.Domain
{
    class Pet
    {
        public string Name { get; set; }
        public string NickName { get; set; }
        public string TypeOfAnimal { get; set; }
        public DateTime Birthday { get; set; }

        public Pet(string name, string nickName, string typeOfAnimal, DateTime birthday)
        {
            Name = name;
            NickName = nickName;
            TypeOfAnimal = typeOfAnimal;
            Birthday = birthday;
        }
    }
}
