using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise2
{
    public class MongoDataAccess : IDataAccess
    {
        public static List<Product> Products = new List<Product>()
        {
            new Product(){ Name="XBox", Price = 150},
            new Product(){ Name="PS4", Price = 170},
            new Product(){ Name="Nintendo Switch", Price = 200},
        };
        public List<Product> LoadData()
        {
            Console.WriteLine("I am reading data from Mongo Data Access.");
            return Products;
        }
        public void SaveData()
        {
            Console.WriteLine("I am saving data to a Mongo Data Access.");
        }
    }
}
