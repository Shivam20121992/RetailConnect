namespace RetailConnectPOS.Model
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DBModelContext : DbContext
    {
        public DBModelContext()
            : base("name=DBModelContext")
        {
        }

        public virtual DbSet<CASHIO> CASHIOs { get; set; }
        public virtual DbSet<CCCharge> CCCharges { get; set; }
        public virtual DbSet<COUNTER> COUNTERs { get; set; }
        public virtual DbSet<CURR> CURRs { get; set; }
        public virtual DbSet<INVFOOTER> INVFOOTERs { get; set; }
        public virtual DbSet<OPENDRAWER_LOG> OPENDRAWER_LOG { get; set; }
        public virtual DbSet<POS> POS { get; set; }
        public virtual DbSet<AR> ARs { get; set; }
        public virtual DbSet<CRECEIPT> CRECEIPTs { get; set; }
        public virtual DbSet<CREDIT> CREDITs { get; set; }
        public virtual DbSet<CUSPRICE> CUSPRICEs { get; set; }
        public virtual DbSet<CUSTOMER> CUSTOMERs { get; set; }
        public virtual DbSet<DEFPRICE> DEFPRICEs { get; set; }
        public virtual DbSet<INVNUM> INVNUMs { get; set; }
        public virtual DbSet<PATH> PATHs { get; set; }
        public virtual DbSet<POSKEYCODE> POSKEYCODEs { get; set; }
        public virtual DbSet<POSRECEIPT1> POSRECEIPT1 { get; set; }
        public virtual DbSet<POSRECEIPT2> POSRECEIPT2 { get; set; }
        public virtual DbSet<PRICETYPE> PRICETYPEs { get; set; }
        public virtual DbSet<PROPOINT> PROPOINTs { get; set; }
        public virtual DbSet<PUSER> PUSERs { get; set; }
        public virtual DbSet<PUSER_BCK> PUSER_BCK { get; set; }
        public virtual DbSet<RIREASON> RIREASONs { get; set; }
        public virtual DbSet<S_ATTENDANCE> S_ATTENDANCE { get; set; }
        public virtual DbSet<SALE> SALES { get; set; }
        public virtual DbSet<SHIFTLOG> SHIFTLOGs { get; set; }
        public virtual DbSet<STAFF> STAFFs { get; set; }
        public virtual DbSet<STOCK> STOCKs { get; set; }
        public virtual DbSet<STORE> STOREs { get; set; }
        public virtual DbSet<TSALE> TSALES { get; set; }
        public virtual DbSet<UPC> UPCs { get; set; }
        public virtual DbSet<VAT_IN> VAT_IN { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CASHIO>()
                .Property(e => e.USERID)
                .IsUnicode(false);

            modelBuilder.Entity<CASHIO>()
                .Property(e => e.DESCRIPTION)
                .IsUnicode(false);

            modelBuilder.Entity<CASHIO>()
                .Property(e => e.SHIFT_ID)
                .IsUnicode(false);

            modelBuilder.Entity<CURR>()
                .Property(e => e.FR_COUNTRY)
                .IsUnicode(false);

            modelBuilder.Entity<CURR>()
                .Property(e => e.FR_RATE)
                .IsFixedLength();

            modelBuilder.Entity<CURR>()
                .Property(e => e.ACTIVE)
                .IsUnicode(false);

            modelBuilder.Entity<OPENDRAWER_LOG>()
                .Property(e => e.USERID)
                .IsUnicode(false);

            modelBuilder.Entity<OPENDRAWER_LOG>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<OPENDRAWER_LOG>()
                .Property(e => e.AUTHID)
                .IsUnicode(false);

            modelBuilder.Entity<POS>()
                .Property(e => e.FIELD1)
                .IsUnicode(false);

            modelBuilder.Entity<S_ATTENDANCE>()
                .Property(e => e.USERID)
                .IsUnicode(false);

            modelBuilder.Entity<S_ATTENDANCE>()
                .Property(e => e.POSTED)
                .IsUnicode(false);

            modelBuilder.Entity<S_ATTENDANCE>()
                .Property(e => e.TYPE)
                .IsUnicode(false);

            modelBuilder.Entity<SALE>()
                .Property(e => e.STORECODE)
                .IsUnicode(false);

            modelBuilder.Entity<SALE>()
                .Property(e => e.PRDCODE)
                .IsUnicode(false);

            modelBuilder.Entity<SALE>()
                .Property(e => e.PRDNAME)
                .IsUnicode(false);

            modelBuilder.Entity<SALE>()
                .Property(e => e.DESCCODE)
                .IsUnicode(false);

            modelBuilder.Entity<SALE>()
                .Property(e => e.PRKEY)
                .IsUnicode(false);

            modelBuilder.Entity<SALE>()
                .Property(e => e.REGPRKEY)
                .IsUnicode(false);

            modelBuilder.Entity<SALE>()
                .Property(e => e.PRNO)
                .IsUnicode(false);

            modelBuilder.Entity<SALE>()
                .Property(e => e.PRTYPECODE)
                .IsUnicode(false);

            modelBuilder.Entity<SALE>()
                .Property(e => e.STYPE)
                .IsUnicode(false);

            modelBuilder.Entity<SALE>()
                .Property(e => e.USERID)
                .IsUnicode(false);

            modelBuilder.Entity<SALE>()
                .Property(e => e.CUSTOMERCODE)
                .IsUnicode(false);

            modelBuilder.Entity<SALE>()
                .Property(e => e.STAFFCODE)
                .IsUnicode(false);

            modelBuilder.Entity<SALE>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<SALE>()
                .Property(e => e.ALTCODE)
                .IsUnicode(false);

            modelBuilder.Entity<SALE>()
                .Property(e => e.TNOW)
                .IsUnicode(false);

            modelBuilder.Entity<SALE>()
                .Property(e => e.AUTHID)
                .IsUnicode(false);

            modelBuilder.Entity<SALE>()
                .Property(e => e.GROUPID)
                .IsUnicode(false);

            modelBuilder.Entity<SALE>()
                .Property(e => e.GROUPID2)
                .IsFixedLength();

            modelBuilder.Entity<SALE>()
                .Property(e => e.CREDITCARDNAME)
                .IsUnicode(false);

            modelBuilder.Entity<SALE>()
                .Property(e => e.VATIN)
                .IsUnicode(false);

            modelBuilder.Entity<SALE>()
                .Property(e => e.PRICELVL)
                .IsUnicode(false);

            modelBuilder.Entity<SALE>()
                .Property(e => e.PRDNAME2)
                .IsUnicode(false);

            modelBuilder.Entity<SALE>()
                .Property(e => e.XYSET)
                .IsUnicode(false);
        }
    }
}
