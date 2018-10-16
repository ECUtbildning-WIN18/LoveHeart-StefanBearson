namespace LoveHeart.Domain
{
    class Appointment
    {
        public string Vet { get; set; }
        public string PetOwner { get; set; }
        public string Pet { get; set; }
        public string Note { get; set; }

        public Appointment(string vet, string petOwner, string pet, string note)
        {
            Vet = vet;
            PetOwner = petOwner;
            Pet = pet;
            Note = note;
        }
    }
}
