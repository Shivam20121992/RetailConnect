namespace RetailConnectPOS.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PUSER")]
    public partial class PUSER
    {
        [StringLength(4)]
        public string UserID { get; set; }

        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string UserName { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(15)]
        public string UserPassword { get; set; }

        [Key]
        [Column(Order = 2)]
        public bool CancelBill { get; set; }

        [Key]
        [Column(Order = 3)]
        public bool CancelItem { get; set; }

        [Key]
        [Column(Order = 4)]
        public bool Resume { get; set; }

        [Key]
        [Column(Order = 5)]
        public bool Suspend { get; set; }

        [Key]
        [Column(Order = 6)]
        public bool CreditS { get; set; }

        [Key]
        [Column(Order = 7)]
        public bool Report { get; set; }

        [Key]
        [Column(Order = 8)]
        public bool Drawer { get; set; }

        [Key]
        [Column(Order = 9)]
        public bool UpdateT { get; set; }

        [Key]
        [Column(Order = 10)]
        public bool Open { get; set; }

        [Key]
        [Column(Order = 11)]
        public bool Config { get; set; }

        [Key]
        [Column(Order = 12)]
        public bool PWP { get; set; }

        [Key]
        [Column(Order = 13)]
        public bool Discount { get; set; }

        [Key]
        [Column(Order = 14)]
        public bool CReceipt { get; set; }

        [Key]
        [Column(Order = 15)]
        public bool Payment { get; set; }

        [Key]
        [Column(Order = 16)]
        public bool PChange { get; set; }

        [Key]
        [Column(Order = 17)]
        public bool OffLine { get; set; }

        [Key]
        [Column(Order = 18)]
        public bool RePrint { get; set; }

        [Key]
        [Column(Order = 19)]
        public bool SalesReturn { get; set; }

        [Key]
        [Column(Order = 20)]
        public bool UserActive { get; set; }

        [Key]
        [Column(Order = 21)]
        public bool Collection { get; set; }

        [Key]
        [Column(Order = 22)]
        public bool SEEKSKU { get; set; }

        [Key]
        [Column(Order = 23)]
        public bool CheckPrice { get; set; }

        [Key]
        [Column(Order = 24)]
        public bool QTY { get; set; }

        public short? CPT { get; set; }
    }
}
