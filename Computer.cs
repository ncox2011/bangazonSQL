namespace bangazonSQL
{
    public class Computer
    {
        public int Id { get; set; }
        public int PurchaseDate { get; set; }
        public int DecomissionDate { get; set; }
        public bool Available { get; set; }
        public bool InRepair { get; set; }
    }
}