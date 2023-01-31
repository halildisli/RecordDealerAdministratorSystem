using RecordDealer.Model;
using System;
using System.Data.Entity;
using System.Linq;

namespace RecordDealer.DAL.Entity
{
    public class RecordDealerEntities : DbContext
    {
        // Your context has been configured to use a 'RecordDealerEntities' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'RecordDealer.DAL.Entity.RecordDealerEntities' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'RecordDealerEntities' 
        // connection string in the application configuration file.
        public RecordDealerEntities()
            : base("name=RecordDealerEntities")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
        public virtual DbSet<Album> Albums { get; set; }
        public virtual DbSet<User> Users { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}