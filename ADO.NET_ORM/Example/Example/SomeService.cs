using System;
using System.Linq;
using DAL.Context;

namespace Example
{
    public class SomeService
    {
        public void DoSmth()
        {
            using (var context = new AppDbContext())
            {
                var items = context.Items.ToList();

                Console.WriteLine($"Items number: {items.Count}");

                foreach (var item in items)
                {
                    Console.WriteLine($"{item.Id} - {item.Description} - {item.Price}");
                }
            }
        }
    }
}