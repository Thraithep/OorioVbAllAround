﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ORM
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class OorioVbAllAroundEntities : DbContext
    {
        public OorioVbAllAroundEntities()
            : base("name=OorioVbAllAroundEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Content> Contents { get; set; }
        public virtual DbSet<ContentType> ContentTypes { get; set; }
        public virtual DbSet<Image> Images { get; set; }
    }
}
