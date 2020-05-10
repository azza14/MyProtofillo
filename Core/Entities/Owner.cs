namespace Core.Entities
{
    class Owner :EntityBase
    {
        public string FullName { get; set; }
        public string Avatar { get; set; }
        public string Profil { get; set; }
        public Address Address { get; set; }

    }
}
