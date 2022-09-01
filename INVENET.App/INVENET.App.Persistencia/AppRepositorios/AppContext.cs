using Microsoft.EntityFrameworkCore;
using INVENET.App.Dominio;

namespace INVENET.App.Persistencia{
    public class AppContext : DbContext{
        public DbSet<Order> Orders {get;set;}
        public DbSet<AdmUser> Admins {get;set;}
        public DbSet<Product> Products {get;set;}
        //public DbSet<State> States {get;set;}
        public DbSet<Supplier> Suppliers {get;set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
            if(!optionsBuilder.IsConfigured){
                optionsBuilder
                .UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = InvenetData");
            }
        }
    }
}