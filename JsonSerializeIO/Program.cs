using System.Text.Json;

namespace JsonSerializeIO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Instrument> list = CreateList();
            List<ComputerStuff> csList = new() { new ComputerStuff() { MyProperty = "Laptop" }, new ComputerStuff() { MyProperty = "Skærm" } };

            Inventory DTO = new() { Instruments = list, ComputerStuffList = csList };
            SaveListToFile(DTO);
        }

        private static void SaveListToFile(Inventory dto)
        {
            string json = JsonSerializer.Serialize(dto);
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            using (StreamWriter file = new StreamWriter(Path.Combine(path, "inventory.json")))
            {
                file.WriteLine(json);
            };
        }

        private static List<Instrument> CreateList()
        {
            //Vi instantierer et object af typen Instrument og tildeler variablen inst referencen til objektet.
            Instrument inst1 = new Instrument() { Type = "El guitar", Name = "Fender Stratocaster", Price = 4000, DateOfPurchase = new DateTime(1989, 6, 20) };
            Instrument inst2 = new Instrument(8000, "Synthesizer", "Korg M1", new DateTime(1989, 12, 24));
            Instrument inst3 = new Instrument();
            inst3.Name = "Moss";
            inst3.Price = 300;
            inst3.DateOfPurchase = new DateTime(2023, 7, 20);
            inst3.Type = "Akustisk guitar";

            List<Instrument> list = new List<Instrument>() { inst2, inst3 };
            list.Add(inst1);
            return list;
        }
    }
}