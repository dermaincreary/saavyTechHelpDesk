﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace saavyTechHelpDesk
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class saavyTechDBE : DbContext
    {
        public saavyTechDBE()
            : base("name=saavyTechDBE")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Brand> Brand { get; set; }
        public virtual DbSet<equiptmentType> equiptmentType { get; set; }
        public virtual DbSet<Jobs> Jobs { get; set; }
        public virtual DbSet<status> status { get; set; }
        public virtual DbSet<userRole> userRole { get; set; }
        public virtual DbSet<Users> Users { get; set; }
    }
}
