using System;
using System.Data.Entity;

namespace AppDAL.NewFolder1
{
  public class ItemContext :DbContext
  {
    static ItemContext()
    {
      System.Data.Entity.Database.SetInitializer(new ItemDbInitializer());
    }

    public ItemContext()
      : base("DefaultConnection")
    {
      
    }

    public DbSet<Item> Items { get; set; }
    
    public class ItemDbInitializer : DropCreateDatabaseIfModelChanges<ItemContext>
    {
      protected override void Seed(ItemContext db)
      {
        var rnd = new Random();
        db.Items.Add(new Item { Id = 0, Price = rnd .NextDouble()});
        db.Items.Add(new Item { Id = 1, Price = rnd.NextDouble() });
        db.Items.Add(new Item { Id = 2, Price = rnd.NextDouble() });
        db.Items.Add(new Item { Id = 3, Price = rnd.NextDouble() });
        db.SaveChanges();
      }
    }
  }
}
