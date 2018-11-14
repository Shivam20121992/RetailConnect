namespace RetailConnectPOS.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SALES")]
    public partial class SALE
    {
        [Key]
        public int SeqNo { get; set; }

        public DateTime? CREATEDATE { get; set; }

        [StringLength(50)]
        public string STORECODE { get; set; }

        [StringLength(50)]
        public string PRDCODE { get; set; }

        [StringLength(100)]
        public string PRDNAME { get; set; }

        [StringLength(50)]
        public string DESCCODE { get; set; }

        public int? QTY { get; set; }

        public int? COST { get; set; }

        public int? ORGPRICE { get; set; }

        public int? PRICE { get; set; }

        public int? REGPRICE { get; set; }

        public int? DISCOUNT { get; set; }

        [StringLength(50)]
        public string PRKEY { get; set; }

        [StringLength(50)]
        public string REGPRKEY { get; set; }

        [StringLength(50)]
        public string PRNO { get; set; }

        [StringLength(50)]
        public string PRTYPECODE { get; set; }

        public int? TPRICE { get; set; }

        [StringLength(50)]
        public string STYPE { get; set; }

        [StringLength(50)]
        public string USERID { get; set; }

        [StringLength(50)]
        public string CUSTOMERCODE { get; set; }

        [StringLength(50)]
        public string STAFFCODE { get; set; }

        public int? COMMISION { get; set; }

        [StringLength(100)]
        public string REMARK { get; set; }

        [StringLength(50)]
        public string ALTCODE { get; set; }

        public int? PRICECHG { get; set; }

        public int? SALPOINT { get; set; }

        [StringLength(50)]
        public string TNOW { get; set; }

        [StringLength(50)]
        public string AUTHID { get; set; }

        [StringLength(50)]
        public string GROUPID { get; set; }

        [StringLength(10)]
        public string GROUPID2 { get; set; }

        public int? LINKID { get; set; }

        [StringLength(50)]
        public string CREDITCARDNAME { get; set; }

        public int? VATPRICE { get; set; }

        [StringLength(50)]
        public string VATIN { get; set; }

        [StringLength(50)]
        public string PRICELVL { get; set; }

        public int? VAT { get; set; }

        public int? GSTPRICE { get; set; }

        public int? UNITGSTPRICE { get; set; }

        public int? GSTDISCOUNT { get; set; }

        public int? ITEMDISCGST { get; set; }

        public int? GSTAmtR4 { get; set; }

        [StringLength(50)]
        public string PRDNAME2 { get; set; }

        [StringLength(50)]
        public string XYSET { get; set; }
    }
}
