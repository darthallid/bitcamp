namespace ReflectionSample
{
    public class Product
    {
        public int Id { get; set; }

        // We do not want to display 'Brand', 
        // we want it to be displayed as 'Marka'.
        [Translation("Marka")]
        public string Brand { get; set; }
    }
}
