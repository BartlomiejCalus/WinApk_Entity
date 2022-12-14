namespace WinApk_Entity.Entities
{
    public class Restaurant
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }

        public int AddressId { get; set; }
        public virtual Address Address { get; set; }
        public virtual List <Dish> Dishes { get; set; }
    }
}
