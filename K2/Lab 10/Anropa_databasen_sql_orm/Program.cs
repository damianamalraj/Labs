using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using anropa_databasen_sql_orm.Data;
using anropa_databasen_sql_orm.Models;

namespace Anropa_databasen_sql_orm
{
  internal class Program
  {
    static void Main(string[] args)
    {
      using (NorthwindContext context = new NorthwindContext())
      {

        Console.Clear();
        Console.WriteLine("Please choose an option:\n1. List all customers\n2. Select a customer for details\n3. Add a new customer\n4. Exit");

        switch (Console.ReadLine())
        {
          case "1":
            fetchAllCustomers(context);
            break;
          case "2":
            selectCustomer(context);
            break;
          case "3":
            AddCustomer(context);
            break;
          case "4":
            return;
          default:
            Console.WriteLine("Invalid option, try again.");
            break;
        }
      };

    }

    static void fetchAllCustomers(NorthwindContext context)
    {
      var customers = context.Customers
                        .Join(context.Orders,
                        c => c.CustomerId,
                        o => o.CustomerId,
                        (c, o) => new { c.CustomerId, c.ContactName, c.CompanyName, c.Country, c.Region, c.Phone, o.OrderId })
                        .GroupBy(c => new { c.CustomerId, c.ContactName, c.CompanyName, c.Country, c.Region, c.Phone })
                        .Select(c => new { c.Key.CustomerId, c.Key.ContactName, c.Key.CompanyName, c.Key.Country, c.Key.Region, c.Key.Phone, OrderCount = c.Count() });

      var orderedCustomersAsc = customers.OrderBy(c => c.CompanyName);
      var orderedCustomersDesc = customers.OrderByDescending(c => c.CompanyName);

      Console.Clear();
      Console.WriteLine("Type 'x' to receive the list in ascending order, or press 'y' for descending order.");
      string? answer = Console.ReadLine();

      if (answer != null)
      {
        if (answer == "x")
        {
          foreach (var item in orderedCustomersAsc)
          {
            Console.WriteLine($"{item.CustomerId} | {item.CompanyName} | {item.Country} | {item.Region} | {item.Phone} | Orders: {item.OrderCount}");
          }
        }
        else if (answer == "y")
        {
          foreach (var item in orderedCustomersDesc)
          {
            Console.WriteLine($"{item.CustomerId} | {item.CompanyName} | {item.Country} | {item.Region} | {item.Phone} | Orders: {item.OrderCount}");
          }
        }

      }
    }

    static void selectCustomer(NorthwindContext context)
    {
      Console.Clear();
      Console.WriteLine("Select a customer to view all their orders. Please write their name.");
      string? input = Console.ReadLine();

      var customer = context.Customers
           .Where(c => c.CustomerId == input)
           .Select(c => new
           {
             c.CompanyName,
             c.ContactName,
             c.ContactTitle,
             c.Address,
             c.City,
             c.Region,
             c.PostalCode,
             c.Country,
             c.Phone,
             Orders = c.Orders.Select(o => new { o.OrderId, o.OrderDate, o.ShippedDate }).ToList()
           })
           .FirstOrDefault();

      if (customer == null)
      {
        Console.WriteLine("Customer not found.");
        return;
      }

      Console.WriteLine($"Company: {customer.CompanyName}\nContact: {customer.ContactName}, {customer.ContactTitle}\nAddress: {customer.Address}\nCity: {customer.City}, {customer.Region}, {customer.PostalCode}\nCountry: {customer.Country}\nPhone: {customer.Phone}\nOrders:");

      foreach (var order in customer.Orders)
      {
        Console.WriteLine($"  Order ID: {order.OrderId}, Order Date: {order.OrderDate}, Shipped Date: {(order.ShippedDate.HasValue ? order.ShippedDate.ToString() : "Not shipped yet")}");
      }
    }

    static void AddCustomer(NorthwindContext context)
    {

      string PromptForInput(string prompt, bool allowNull)
      {
        string input;
        do
        {
          Console.WriteLine(prompt);
          input = Console.ReadLine();
          if (allowNull)
          {
            return string.IsNullOrWhiteSpace(input) ? null : input;
          }
        } while (string.IsNullOrWhiteSpace(input));
        return input;
      }

      string GenerateRandomCustomerID()
      {
        var random = new Random();
        const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
        return new string(Enumerable.Repeat(chars, 5)
          .Select(s => s[random.Next(s.Length)]).ToArray());
      }

      var customer = new Customer
      {
        CustomerId = GenerateRandomCustomerID(),
        CompanyName = PromptForInput("Enter company name: ", false),
        ContactName = PromptForInput("Enter contact name: ", true),
        ContactTitle = PromptForInput("Enter contact title: ", true),
        Address = PromptForInput("Enter address: ", true),
        City = PromptForInput("Enter city: ", true),
        Region = PromptForInput("Enter region: ", true),
        PostalCode = PromptForInput("Enter postal code: ", true),
        Country = PromptForInput("Enter country: ", true),
        Phone = PromptForInput("Enter phone number: ", true),
      };

      context.Customers.Add(customer);
      context.SaveChanges();
      Console.WriteLine($"New customer added with ID: {customer.CustomerId}");
    }

  }
}

