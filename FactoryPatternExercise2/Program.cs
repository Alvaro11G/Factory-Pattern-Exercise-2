namespace FactoryPatternExercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            string? userInput;
            bool correctInput;
            do {
                Console.Clear();

                correctInput = true;

                Console.WriteLine("What data base would you like? (Mongo, SQL, List)");
                userInput = Console.ReadLine();

                if(userInput != "SQL" && userInput != "Mongo" && userInput != "List")
                {
                    correctInput = false;
                }
            } while (correctInput == false);

            IDataAccess db = DataAccessFactory.GetDataAccessType(userInput!);

            var products = db.LoadData();
            db.SaveData();

            foreach(var product in products)
            {
                Console.WriteLine($"Name: {product.Name}, Price: ${product.Price}");
            }
        }
    }
}