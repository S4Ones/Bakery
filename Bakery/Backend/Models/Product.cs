namespace Bakery.Models
{
    public class Product
    {
        public int Id { set; get; }
        public string Name { set; get; }
        public string Description { set; get; }
        public ushort Price { set; get; }
        public bool isFavourite { set; get; }
        public string img { set; get; }
        public int categoryID { set; get; }
        public virtual Category Category { set; get; }
    }
}
