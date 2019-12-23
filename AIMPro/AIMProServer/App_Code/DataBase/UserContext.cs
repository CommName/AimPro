using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
/// <summary>
/// Summary description for UserContext
/// </summary>
public class UserContext : DbContext
{
    public DbSet<User> Users { get; set; }
    public DbSet<Matches> Matches { get; set; }

    public UserContext()
    {
        Database.SetInitializer<UserContext>(new DropCreateDatabaseIfModelChanges<UserContext>());
        //
        // TODO: Add constructor logic here
        //
    }
}