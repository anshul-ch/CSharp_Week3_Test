namespace CSharp_Week3_Test.UseCase2_Online_Order_Processing
{
    /// <summary>
    /// Represents a product in the catalog
    /// </summary>
    public class Product
    {
        // Encapsulated fields
        private int ProdId;
        private string ProdName;
        private decimal ProdPrice;

        public int Id => ProdId;
        public string Name => ProdName;
        public decimal Price => ProdPrice;

        public Product(int id, string name, decimal price)
        {
            ProdId = id;
            ProdName = name;
            ProdPrice = price;
        }
    }
}

