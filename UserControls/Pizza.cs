namespace UserControls
{
    public class Pizza : IPizza
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public string Image { get; set; }

        public double Price { get; set; }

        public bool IsInStock { get; set; }

        public string Comments { get; set; }

        public Pizza(int id, string name, double price = 4.99, string image = "http://placekitten.com/200/200", bool isInStock = true, string comments = "")
        {
            ID = id;
            Name = name;
            Image = image;
            Price = price;
            IsInStock = isInStock;
            Comments = comments;
        }
    }
}