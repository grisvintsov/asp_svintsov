﻿//------------------------------------------------------------------------------
// <auto-generated>
//    Этот код был создан из шаблона.
//
//    Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//    Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class svintsovEntities : DbContext
    {
        public svintsovEntities()
            : base("name=svintsovEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Accounts> Accounts { get; set; }
        public DbSet<Bag> Bag { get; set; }
        public DbSet<Characters> Characters { get; set; }
        public DbSet<Colors> Colors { get; set; }
        public DbSet<Genders> Genders { get; set; }
        public DbSet<Items> Items { get; set; }
        public DbSet<Profs> Profs { get; set; }
        public DbSet<Races> Races { get; set; }
        public DbSet<Rights> Rights { get; set; }
        public DbSet<Stats> Stats { get; set; }
        public DbSet<sysdiagrams> sysdiagrams { get; set; }
        public DbSet<Types> Types { get; set; }
    }
}
