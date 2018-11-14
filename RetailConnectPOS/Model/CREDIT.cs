namespace RetailConnectPOS.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CREDIT")]
    public partial class CREDIT
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(2)]
        public string CREDITCODE { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(40)]
        public string CREDITDESC { get; set; }

        public int? TYPE { get; set; }

        public int? TYPE1 { get; set; }

        public int? TYPE2 { get; set; }

        [Key]
        [Column(Order = 2)]
        public bool CHK { get; set; }

        [Key]
        [Column(Order = 3)]
        public bool DEPOSIT { get; set; }

        [Key]
        [Column(Order = 4)]
        public bool creditcard { get; set; }

        [Key]
        [Column(Order = 5)]
        public bool debitcard { get; set; }

        [Key]
        [Column(Order = 6)]
        public bool tax { get; set; }

        [Key]
        [Column(Order = 7)]
        public bool voucher { get; set; }

        [Key]
        [Column(Order = 8)]
        public bool RES01 { get; set; }

        [Key]
        [Column(Order = 9)]
        public bool RES02 { get; set; }

        [Key]
        [Column(Order = 10)]
        public bool RES03 { get; set; }
    }
}
