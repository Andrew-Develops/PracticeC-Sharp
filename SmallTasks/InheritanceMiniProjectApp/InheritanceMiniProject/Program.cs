using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceMiniProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<InventoryItemModel> inventory = new List<InventoryItemModel>();
            List<IRentable> rentables = new List<IRentable>();
            List<IPurchasable> purchasables = new List<IPurchasable>();

            var vehicle = new VehicleModel { DealerFee = 25, ProductName = "Kia Optima" };
            var book = new BookModel { ProductName = "A Tale of Two Cities", NumberOfPages = 350 };
            var excavator = new ExcavatorModel { ProductName = "Bulldozer", QuantityInStock = 2 };

            rentables.Add(vehicle);
            rentables.Add(excavator);

            purchasables.Add(book);
            purchasables.Add(vehicle);

            Console.Write("Do you want to 'rent' or 'purchase' something: ");
            string rentalDecision = Console.ReadLine();

            if (rentalDecision.ToLower() == "rent")
            {
                foreach (IRentable item in rentables)
                {
                    Console.WriteLine($"Item: {item.ProductName}");
                    Console.WriteLine("Do you want to rent this item: 'y' or 'n'.");
                    string wantToRent = Console.ReadLine();

                    if (wantToRent.ToLower() == "y")
                    {
                        item.Rent();
                    }

                    Console.WriteLine($"Item: {item.ProductName}");
                    Console.WriteLine("Do you want to return this item: 'y' or 'n'.");
                    string wantToReturn = Console.ReadLine();

                    if (wantToReturn.ToLower() == "y")
                    {
                        item.ReturnRental();
                    }
                }
            }
            else
            {
                foreach (var item in purchasables)
                {
                    Console.WriteLine($"Item: {item.ProductName}");
                    Console.Write("Do you want to buy this item: 'y' or 'n'.");
                    string wantToBuy = Console.ReadLine();

                    if (wantToBuy.ToLower() == "y")
                    {
                        item.Purchase();
                    }
                }
            }
            Console.WriteLine("We are done");

            Console.ReadLine();
        }
    }

}
