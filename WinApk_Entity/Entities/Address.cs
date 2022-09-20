namespace WinApk_Entity.Entities
{
    internal class Address
    {
        public int Id { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string PostCode { get; set; }

        public virtual Restaurant Restaurant { get; set; }
    }
}
