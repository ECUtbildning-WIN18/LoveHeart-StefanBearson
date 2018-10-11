using LoveHeart.Domain;
using System.Collections.Generic;
using System.Xml.Linq;

namespace LoveHeart.Services
{
    class CustomerAndPetLoader : ICustomerLoader
    {
        public List<PetOwner> LoadUsers()
        {
            var customers = new List<PetOwner>();
            //TODO: set right xml file
            var doc = XDocument.Load("CustomersTemp.xml");

            var root = doc.Root;

            foreach (var element in root.Elements())
            {
                var firstName = element.Attribute("firstname").Value;
                var lastName = element.Attribute("lastname").Value;
                var socialNumber = element.Attribute("socialsecuritynumber").Value;
                var petList = new List<Pet>();

                foreach (var pet in element.Elements("pet"))
                {
                    var petName = pet.Attribute("name").Value;
                    var type = pet.Attribute("type").Value;
                    var nickname = pet.Attribute("nickname").Value;
                    petList.Add(new Pet(petName, nickname, type));
                }
                customers.Add(new PetOwner(firstName, lastName, socialNumber, petList));
            }
            return customers;
        }
    }
}
