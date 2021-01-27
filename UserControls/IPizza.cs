namespace UserControls
{
    public interface IPizza
    {
        string Comments { get; set; }
        string Image { get; set; }
        bool IsInStock { get; set; }
        string Name { get; set; }
        double Price { get; set; }
    }
}