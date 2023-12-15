using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Northwind_EF.Data;
using Northwind_EF.Models;

namespace Northwind_EF
{
    internal class Program
    {
        internal static void Main(string[] args)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var ukOrders = context.Orders
                            .Where(o => o.ShipCountry == "UK")
                            .Select(o => new { o.ShipAddress, o.ShipName, o.ShipCity })
                            .ToList();

                foreach (var order in ukOrders)
                {
                    Console.WriteLine($"{order.ShipCity}, {order.ShipAddress}, {order.ShipName}");
                }
            }
        }
    }
}