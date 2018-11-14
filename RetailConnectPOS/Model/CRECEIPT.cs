namespace RetailConnectPOS.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CRECEIPT")]
    public partial class CRECEIPT
    {
        [Key]
        [Column(Order = 0)]
        public int AUDIT_NO { get; set; }

        public DateTime? CREATEDATE { get; set; }

        [StringLength(10)]
        public string STORECODE { get; set; }

        [StringLength(7)]
        public string PRDCODE { get; set; }

        [StringLength(40)]
        public string PRDNAME { get; set; }

        public double? QTY { get; set; }

        public double? COST { get; set; }

        public double? ORGPRICE { get; set; }

        public double? PRICE { get; set; }

        public double? REGPRICE { get; set; }

        public double? DISCOUNT { get; set; }

        [StringLength(14)]
        public string PRKEY { get; set; }

        [StringLength(14)]
        public string REGPRKEY { get; set; }

        [StringLength(12)]
        public string PRNO { get; set; }

        [StringLength(2)]
        public string PRTYPECODE { get; set; }

        public double? TPRICE { get; set; }

        [StringLength(2)]
        public string STYPE { get; set; }

        public int? INVNUM { get; set; }

        [StringLength(4)]
        public string USERID { get; set; }

        [StringLength(30)]
        public string CUSTOMERCODE { get; set; }

        [StringLength(12)]
        public string COUNTERCODE { get; set; }

        [StringLength(30)]
        public string STAFFCODE { get; set; }

        public double? COMMISION { get; set; }

        [Key]
        [Column(Order = 1)]
        public bool POSTED { get; set; }

        public DateTime? UPLOADDATE { get; set; }

        public DateTime? CANCELDATE { get; set; }

        [StringLength(50)]
        public string USERNAME { get; set; }

        public DateTime? DOWNLOADDATE3 { get; set; }

        [StringLength(40)]
        public string REMARK { get; set; }

        [StringLength(18)]
        public string ALTCODE { get; set; }

        [StringLength(3)]
        public string RIREASON { get; set; }

        public double? PRICECHG { get; set; }

        public double? SALPOINT { get; set; }

        public DateTime? TNOW { get; set; }

        [StringLength(4)]
        public string AUTHID { get; set; }

        [StringLength(40)]
        public string REMARK2 { get; set; }

        public short? SHIFT { get; set; }

        [StringLength(10)]
        public string SHIFT_ID { get; set; }

        [StringLength(10)]
        public string VATIN { get; set; }

        public double? VATPRICE { get; set; }

        [StringLength(1)]
        public string PRICELVL { get; set; }

        public double? GSTPRICE { get; set; }
    }
}
