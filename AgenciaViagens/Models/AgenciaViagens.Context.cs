﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AgenciaViagens.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class AgenciaViagensEntities : DbContext
    {
        public AgenciaViagensEntities()
            : base("name=AgenciaViagensEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Adquire> Adquire { get; set; }
        public virtual DbSet<Cliente> Cliente { get; set; }
        public virtual DbSet<Destino> Destino { get; set; }
        public virtual DbSet<Promocao> Promocao { get; set; }
        public virtual DbSet<Viagem> Viagem { get; set; }
    }
}
