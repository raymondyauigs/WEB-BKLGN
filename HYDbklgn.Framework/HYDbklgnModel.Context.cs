﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HYDbklgn.Framework
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class HYDbklgnEntities : DbContext
    {
        public HYDbklgnEntities()
            : base("name=HYDbklgnEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<CoreSetting> CoreSettings { get; set; }
        public virtual DbSet<CoreUser> CoreUsers { get; set; }
    }
}
