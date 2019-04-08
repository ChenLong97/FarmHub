namespace Model.EF
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class FarmHubDbContext : DbContext
    {
        public FarmHubDbContext()
            : base("name=FarmHubDbContext")
        {
        }

        public virtual DbSet<CLASSIFICATION> CLASSIFICATIONs { get; set; }
        public virtual DbSet<CROP> CROPs { get; set; }
        public virtual DbSet<FARM> FARMs { get; set; }
        public virtual DbSet<FARM_DETAIL> FARM_DETAIL { get; set; }
        public virtual DbSet<FARMER> FARMERs { get; set; }
        public virtual DbSet<FARMER_PREFERENCE> FARMER_PREFERENCE { get; set; }
        public virtual DbSet<FARMER_PREFERENCE_DETAIL> FARMER_PREFERENCE_DETAIL { get; set; }
        public virtual DbSet<MARKET_TRANS_HIS> MARKET_TRANS_HIS { get; set; }
        public virtual DbSet<MASS_UNIT> MASS_UNIT { get; set; }
        public virtual DbSet<PRODUCT> PRODUCTs { get; set; }
        public virtual DbSet<PRODUCT_KIND> PRODUCT_KIND { get; set; }
        public virtual DbSet<PURCHASE_OFFER> PURCHASE_OFFER { get; set; }
        public virtual DbSet<PURCHASE_OFFER_DETAIL> PURCHASE_OFFER_DETAIL { get; set; }
        public virtual DbSet<SALE_OFFER> SALE_OFFER { get; set; }
        public virtual DbSet<SALE_OFFER_DETAIL> SALE_OFFER_DETAIL { get; set; }
        public virtual DbSet<SEED> SEEDs { get; set; }
        public virtual DbSet<TRADER> TRADERs { get; set; }
        public virtual DbSet<TRANSACTION_ORDER> TRANSACTION_ORDER { get; set; }
        public virtual DbSet<USER_AUTHENTICATION> USER_AUTHENTICATION { get; set; }
        public virtual DbSet<USER_KIND> USER_KIND { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FARMER>()
                .Property(e => e.Image_Farmer)
                .IsUnicode(false);

            modelBuilder.Entity<MASS_UNIT>()
                .Property(e => e.Name_MassUnit)
                .IsUnicode(false);

            modelBuilder.Entity<PRODUCT>()
                .Property(e => e.Image_Product)
                .IsUnicode(false);

            modelBuilder.Entity<TRADER>()
                .Property(e => e.Image_Trader)
                .IsUnicode(false);

            modelBuilder.Entity<USER_AUTHENTICATION>()
                .Property(e => e.Name_User)
                .IsUnicode(false);

            modelBuilder.Entity<USER_AUTHENTICATION>()
                .Property(e => e.Password_User)
                .IsUnicode(false);
        }
    }
}
