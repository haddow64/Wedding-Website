﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Wedding_Website.Models
{
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.ModelConfiguration.Conventions;

    public partial class Wedding_DataEntities : DbContext
    {
        public Wedding_DataEntities() : base("name=Wedding_DataEntities")
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<Wedding_DataEntities>());
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AdditionalRSVP> AdditionalRSVPs { get; set; }
        public virtual DbSet<RSVP> RSVPs { get; set; }
    }
}
