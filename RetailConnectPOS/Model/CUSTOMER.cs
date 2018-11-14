namespace RetailConnectPOS.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CUSTOMER")]
    public partial class CUSTOMER
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(30)]
        public string CUSTOMERCODE { get; set; }

        [StringLength(40)]
        public string CUSTOMERNAME { get; set; }

        [StringLength(20)]
        public string IC { get; set; }

        public DateTime? BDATE { get; set; }

        [StringLength(1)]
        public string MARITALCODE { get; set; }

        [StringLength(1)]
        public string SEXCODE { get; set; }

        [StringLength(40)]
        public string ADDRESS1 { get; set; }

        [StringLength(40)]
        public string ADDRESS2 { get; set; }

        [StringLength(60)]
        public string ADDRESS3 { get; set; }

        [StringLength(20)]
        public string HTEL { get; set; }

        [StringLength(20)]
        public string OTEL { get; set; }

        [StringLength(20)]
        public string MTEL { get; set; }

        [StringLength(20)]
        public string FAX { get; set; }

        [StringLength(50)]
        public string EMAIL { get; set; }

        public DateTime? NDATE { get; set; }

        public DateTime? CREATEDATE { get; set; }

        public DateTime? LDATE { get; set; }

        public DateTime? MODIFYDATE { get; set; }

        [StringLength(50)]
        public string REMARK { get; set; }

        [StringLength(40)]
        public string OCCU { get; set; }

        public double? CREDITLIMIT { get; set; }

        [StringLength(2)]
        public string CREDITTYPE { get; set; }

        [StringLength(20)]
        public string ALTCODE { get; set; }

        public int? UPDATENO { get; set; }

        public DateTime? UPDATEDATE { get; set; }

        [StringLength(30)]
        public string AREACODE { get; set; }

        [StringLength(30)]
        public string PRICEZONE { get; set; }

        public double? MPOINT { get; set; }

        [StringLength(30)]
        public string CUSTGROUPCODE { get; set; }

        [StringLength(30)]
        public string MASTERCODE { get; set; }

        [Key]
        [Column(Order = 1)]
        public bool Active { get; set; }

        [StringLength(15)]
        public string ACC_CODE { get; set; }

        public double? CREDIT_BALANCE { get; set; }

        [Key]
        [Column(Order = 2)]
        public bool BLOCK_ACC { get; set; }
    }
}
