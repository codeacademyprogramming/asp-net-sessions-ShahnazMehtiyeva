namespace Task.Context
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using Task.Models;

    public class UsersDb : DbContext
    {
        public UsersDb()
            : base("name=UsersDb")
        {
        }

        public DbSet<Users> Users { get; set; }
    }

}