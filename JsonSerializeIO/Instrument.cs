namespace JsonSerializeIO
{
    internal class Instrument
    {
        public int NumOfInstruments;
        public Instrument()
        {

        }
        public Instrument(int price, string type, string name, DateTime dateOfPurchase)
        {
            Price = price;
            Type = type;
            Name = name;
            DateOfPurchase = dateOfPurchase;
        }

        public int Price { get; set; }
        public string? Type { get; set; }
        public string? Name { get; set; }
        public DateTime DateOfPurchase { get; set; }
    }
}
