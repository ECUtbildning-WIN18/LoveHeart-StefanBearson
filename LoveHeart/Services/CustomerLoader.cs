using LoveHeart.Domain;
using System.Collections.Generic;
using System.Xml.Linq;

namespace LoveHeart.Services
{
    class CustomerLoader : ICustomerLoader
    {
        public List<PetOwner> LoadUsers()
        {
            var customers = new List<PetOwner>();

            var doc = XDocument.Load("Customers.xml");

            var root = doc.Root;

            foreach (var element in root.Elements())
            {
                var firstName = element.Attribute("firstName").Value;
                var lastName = element.Attribute("lastName").Value;
                var socialNumber = element.Attribute("SocialSecurityNumber").Value;

                customers.Add(new PetOwner(firstName, lastName, socialNumber));
            }
            return customers;
        }
    }
}
