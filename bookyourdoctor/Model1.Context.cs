﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace bookyourdoctor
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class FINALSCRIPTEntities : DbContext
    {
        public FINALSCRIPTEntities()
            : base("name=FINALSCRIPTEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AspNetRole> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaim> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogin> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUser> AspNetUsers { get; set; }
        public virtual DbSet<Clinic_request> Clinic_request { get; set; }
        public virtual DbSet<doctor> doctors { get; set; }
        public virtual DbSet<doctor_avaliability> doctor_avaliability { get; set; }
        public virtual DbSet<doctor_scedule> doctor_scedule { get; set; }
        public virtual DbSet<Hospital_request> Hospital_request { get; set; }
        public virtual DbSet<hospital_view> hospital_view { get; set; }
        public virtual DbSet<patient> patients { get; set; }
        public virtual DbSet<specialization> specializations { get; set; }
        public virtual DbSet<admin> admins { get; set; }
        public virtual DbSet<clinic_view> clinic_view { get; set; }
    }
}