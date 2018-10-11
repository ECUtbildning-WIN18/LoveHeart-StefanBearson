using LoveHeart.Domain;
using System.Xml.Linq;

namespace LoveHeart.Services
{
    class CustomerSaver
    {
        public static XDocument customerlist = XDocument.Load("Customers.xml");

        public static void Save(PetOwner customer)
        {

            {
                //var customerlist = XDocument.Load("Customers.xml");

                var root = customerlist.Root;

                var customerInfo = new XElement("Customer",
                    new XAttribute("firstname", customer.FirstName),
                    new XAttribute("lastname", customer.LastName),
                    new XAttribute("socialsecuritynumber", customer.SocialSecurityNumber));

                foreach (var pets in customer.OwnerAnimals)
                {
                    var customerPet =
                        new XElement("pet",
                            new XAttribute("type", pets.TypeOfAnimal),
                            new XAttribute("name", pets.Name),
                            new XAttribute("nickname", pets.NickName));
                    customerInfo.Add(customerPet);
                }

                root.Add(customerInfo);

                //customerlist.Save("CustomersTemp.xml");
            }
        }

        public static void AddOneAndSave(PetOwner customer, Pet pet)
        {
            var customerlist = XDocument.Load("CustomersTemp.xml");

            var root = customerlist.Root;

            var customerInfo = new XElement("Customer",
                new XAttribute("firstname", customer.FirstName),
                new XAttribute("lastname", customer.LastName),
                new XAttribute("socialsecuritynumber", customer.SocialSecurityNumber));

            var customerPet =
                new XElement("pet",
                    new XAttribute("type", pet.TypeOfAnimal),
                    new XAttribute("name", pet.Name),
                    new XAttribute("nickname", pet.NickName));
            customerInfo.Add(customerPet);

            root.Add(customerInfo);

            customerlist.Save("CustomersTemp.xml");
        }
    }
}
