using System;
using System.Data.Entity;
using System.Threading.Tasks;
using DAL.Context;

namespace EF_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            MainAsync().Wait();
        }

        static async Task MainAsync()
        {
            using (var context = new AppDbContext())
            {
                await context.Customers.CountAsync(); //Do not delete this line. It triggers configuration check for database

                Process(context);
            }

            Console.WriteLine("Main Async Completed");
        }


        //TODO: get all customers with it orders (skip items & order_items data) in a 1 SQL query. Use SQL Profiler to ensure that only 1 query has been executed.
        static void Process(AppDbContext context)
        {

        }
    }
}
