using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.XPath;
using LoveHeart.Domain;

namespace LoveHeart.Services
{
    class CustomerAndPetLoader : ICustomerLoader
    {
        public List<PetOwner> LoadUsers()
        {
            var customers = new List<PetOwner>();

            var doc = XDocument.Load("CustomerAndPets.xml");

            var root = doc.Root;
            

            foreach (var element in root.Elements())
            {
                var firstName = element.Attribute("firstName").Value;
                var lastName = element.Attribute("lastName").Value;
                var socialNumber = element.Attribute("SocialSecurityNumber").Value;
                var petList = new List<Pet>();
                

                foreach (var pet in element.Elements("Pets").Elements())
                {

                    var petName = pet.Attribute("name").Value;
                    petList.Add(new Pet(petName, "ollo", "dog", new DateTime(2009,01,01)));
                    
                    
                }
                customers.Add(new PetOwner(firstName, lastName, socialNumber, petList));
                
                
                
            }
            return customers;
        }
    }
}
