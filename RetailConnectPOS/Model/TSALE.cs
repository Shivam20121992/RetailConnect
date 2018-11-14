namespace RetailConnectPOS.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TSALES")]
    public partial class TSALE
    {
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

        public double? INVNUM { get; set; }

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
        [Column(Order = 0)]
        public bool POSTED { get; set; }

        public DateTime? POSTDATE { get; set; }

        public DateTime? DOWNLOADDATE3 { get; set; }

        [Key]
        [Column(Order = 1)]
        public int AUDIT_NO { get; set; }

        public double? BANKPAY { get; set; }

        [StringLength(40)]
        public string REMARK { get; set; }

        public DateTime? PAYMENTDATE { get; set; }

        [StringLength(18)]
        public string ALTCODE { get; set; }

        [StringLength(3)]
        public string RIREASON { get; set; }

        public double? PRICECHG { get; set; }

        public double? SALPOINT { get; set; }

        public DateTime? TNOW { get; set; }

        public DateTime? DOWNLOADDATE1 { get; set; }

        public DateTime? DOWNLOADDATE2 { get; set; }

        public DateTime? DOWNLOADDATE4 { get; set; }

        public DateTime? UPLOADDATE1 { get; set; }

        public DateTime? UPLOADDATE2 { get; set; }

        public double? POSAUDIT_NO { get; set; }

        [StringLength(10)]
        public string PH1CODE { get; set; }

        [StringLength(10)]
        public string RACE { get; set; }

        [Key]
        [Column(Order = 2)]
        public bool MPPOSTED { get; set; }

        [StringLength(4)]
        public string AuthID { get; set; }

        public double? HISTORY_COST { get; set; }

        public double? SUPPLIER_COST { get; set; }

        public double? SUPP_CLAIM { get; set; }

        public double? ORG_COST { get; set; }

        [StringLength(40)]
        public string REMARK2 { get; set; }

        [StringLength(7)]
        public string CCODE { get; set; }

        public double? CCFRACTION { get; set; }

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
