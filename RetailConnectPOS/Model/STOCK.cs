namespace RetailConnectPOS.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("STOCK")]
    public partial class STOCK
    {
        [StringLength(10)]
        public string PH1CODE { get; set; }

        [StringLength(10)]
        public string PH2CODE { get; set; }

        [StringLength(10)]
        public string PH3CODE { get; set; }

        [StringLength(10)]
        public string PH4CODE { get; set; }

        [StringLength(10)]
        public string PH5CODE { get; set; }

        [StringLength(10)]
        public string PH6CODE { get; set; }

        [Key]
        [Column(Order = 0)]
        [StringLength(7)]
        public string PRDCODE { get; set; }

        [StringLength(40)]
        public string PRDNAME { get; set; }

        public double? OHB { get; set; }

        public double? COST { get; set; }

        public double? NEWCOST { get; set; }

        public DateTime? CDATE { get; set; }

        [StringLength(1)]
        public string STATUSCODE { get; set; }

        public DateTime? CREATEDATE { get; set; }

        public DateTime? MODIFYDATE { get; set; }

        public double? FRACTION { get; set; }

        public double? MINQTY { get; set; }

        public double? MAXQTY { get; set; }

        public DateTime? DELETEDATE { get; set; }

        public double? PRICE { get; set; }

        public double? REGPRICE { get; set; }

        [StringLength(20)]
        public string DESCCODE { get; set; }

        [StringLength(20)]
        public string ARTICLE { get; set; }

        [StringLength(5)]
        public string COLORCODE { get; set; }

        [StringLength(5)]
        public string SIZECODE { get; set; }

        [StringLength(3)]
        public string COUNTRYCODE { get; set; }

        [StringLength(5)]
        public string BRANDCODE { get; set; }

        [StringLength(5)]
        public string UOMCODE { get; set; }

        [StringLength(7)]
        public string CCODE { get; set; }

        public int? FRESH { get; set; }

        [StringLength(14)]
        public string PRKEY { get; set; }

        [StringLength(14)]
        public string REGPRKEY { get; set; }

        [StringLength(12)]
        public string PRNO { get; set; }

        [StringLength(2)]
        public string PRTYPECODE { get; set; }

        [StringLength(10)]
        public string DBCMFIELD1 { get; set; }

        [StringLength(10)]
        public string DBCMFIELD2 { get; set; }

        [StringLength(10)]
        public string DBCMFIELD3 { get; set; }

        public int? UPDATENO { get; set; }

        public DateTime? UPDATEDATE { get; set; }

        public double? DCCOST { get; set; }

        public double? OLDPRICE { get; set; }

        public DateTime? OLDPRICEDATE { get; set; }

        public double? TCOST { get; set; }

        [StringLength(40)]
        public string ALTCODE { get; set; }

        [StringLength(10)]
        public string PRICETYPECODE { get; set; }

        public double? GP { get; set; }

        public DateTime? LASTPURCHDATE { get; set; }

        public DateTime? LASTSALEDATE { get; set; }

        public DateTime? LASTTRANINDATE { get; set; }

        public DateTime? LASTTRANOUTDATE { get; set; }

        [StringLength(10)]
        public string LASTVENDOR { get; set; }

        public double? WAC { get; set; }

        [StringLength(10)]
        public string VATIN { get; set; }

        public double? VATOUT { get; set; }

        [Key]
        [Column(Order = 1)]
        public bool UPDATEOHB { get; set; }

        [Key]
        [Column(Order = 2)]
        public bool OPENPRICE { get; set; }

        public double? VATPRICE { get; set; }

        public DateTime? OPBAL_DATE { get; set; }

        public double? OPBAL_QTY { get; set; }

        public double? OPBAL_COST { get; set; }

        public DateTime? OPBAL_EDATE { get; set; }

        public double? OPBAL_PRICE { get; set; }

        public double? VAT { get; set; }

        [StringLength(40)]
        public string PRDNAME2 { get; set; }
    }
}
