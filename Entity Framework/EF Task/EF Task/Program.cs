using System;
using System.Data.Entity;
using System.Linq;
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

                await Process(context);
            }

            Console.WriteLine("Main Async Completed");
        }


        //TODO: Grab all tables data in a 1 SQL query.
        //TODO: Use eager loading with nested LINQ Select queries to achieve that.
        //TODO: Use SQL Profiler to ensure that only 1 query has been executed. 
        //TODO: SQL Query result (can be checked via SQL management studio) must looks like denormalized data from initial "Internation widgets.xlsx" file (without Item Total & Order Total Price columns)
        static async Task Process(AppDbContext context)
        {

        }
    }
}
