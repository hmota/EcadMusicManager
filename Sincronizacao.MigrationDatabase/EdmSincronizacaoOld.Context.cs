﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SincronizacaoMusical.MigrationDatabase
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class SincOldEntities : DbContext
    {
        public SincOldEntities()
            : base("name=SincOldEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<SINCTASSO> SINCTASSO { get; set; }
        public DbSet<SincClassificacao> SINCTCLAS { get; set; }
        public DbSet<SINCTEDIT> SINCTEDIT { get; set; }
        public DbSet<SINCTEXIB> SINCTEXIB { get; set; }
        public DbSet<SincGeneroClassificacao> SINCGECL { get; set; }
        public DbSet<SincGenero> SINCTGENE { get; set; }
        public DbSet<SINCTISRC> SINCTISRC { get; set; }
        public DbSet<SINCTMUSI> SINCTMUSI { get; set; }
        public DbSet<SINCTPCGE> SINCTPCGE { get; set; }
        public DbSet<SINCTPRCL> SINCTPRCL { get; set; }
        public DbSet<SINCTPROD> SINCTPROD { get; set; }
        public DbSet<SINCTSINC> SINCTSINC { get; set; }
        public DbSet<SINCTSIQD> SINCTSIQD { get; set; }
        public DbSet<SINCTSLOG> SINCTSLOG { get; set; }
        public DbSet<SINCTTREC> SINCTTREC { get; set; }
        public DbSet<SINCTTRIB> SINCTTRIB { get; set; }
        public DbSet<SINCTUNID> SINCTUNID { get; set; }
        public DbSet<SINCTWFNC> SINCTWFNC { get; set; }
        public DbSet<trilhas_vetrix> trilhas_vetrix { get; set; }
        public DbSet<dtproperties> dtproperties { get; set; }
        public DbSet<SINCTPREC> SINCTPREC { get; set; }
        public DbSet<SINCTAUTO> SINCTAUTO { get; set; }
    }
}