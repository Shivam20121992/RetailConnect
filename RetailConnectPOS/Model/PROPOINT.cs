namespace RetailConnectPOS.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PROPOINT")]
    public partial class PROPOINT
    {
        [Key]
        [Column(Order = 0)]
        public int AUDIT_NO { get; set; }

        public DateTime? CREATEDATE { get; set; }

        [StringLength(10)]
        public string STORECODE { get; set; }

        public double? POINT { get; set; }

        public double? POSAMOUNT { get; set; }

        [StringLength(4)]
        public string USERID { get; set; }

        [StringLength(30)]
        public string CUSTOMERCODE { get; set; }

        [StringLength(12)]
        public string COUNTERCODE { get; set; }

        [StringLength(40)]
        public string REMARK { get; set; }

        [StringLength(1)]
        public string PTYPE { get; set; }

        public int? INVNUM { get; set; }

        [Key]
        [Column(Order = 1)]
        public bool POSTED { get; set; }

        public DateTime? UPLOADDATE { get; set; }

        public DateTime? UPLOADDATE1 { get; set; }

        public DateTime? UPLOADDATE2 { get; set; }

        public DateTime? DOWNLOADDATE1 { get; set; }

        public DateTime? DOWNLOADDATE2 { get; set; }

        public int? HASHKEY { get; set; }

        public bool? DUPLICATED { get; set; }

        [StringLength(20)]
        public string CUSTUID { get; set; }

        public DateTime? TRANDATE { get; set; }

        public double? GSTPRICE { get; set; }

        [StringLength(30)]
        public string TRANID { get; set; }
    }
}
