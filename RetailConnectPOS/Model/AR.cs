namespace RetailConnectPOS.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AR")]
    public partial class AR
    {
        [Key]
        [Column(Order = 0)]
        public int SNO { get; set; }

        public DateTime? CREATEDATE { get; set; }

        public DateTime? TRANSDATE { get; set; }

        [StringLength(10)]
        public string STORECODE { get; set; }

        [StringLength(12)]
        public string COUNTERCODE { get; set; }

        public double? INVNUM { get; set; }

        [StringLength(30)]
        public string CUSTOMERCODE { get; set; }

        public double? AMOUNT { get; set; }

        [StringLength(50)]
        public string ARDESC { get; set; }

        [StringLength(1)]
        public string TRANTYPE { get; set; }

        [Key]
        [Column(Order = 1)]
        public bool POSTED { get; set; }

        public DateTime? RELEASEDATE { get; set; }

        public double? TPAYMENT { get; set; }

        [StringLength(40)]
        public string REMARK { get; set; }
    }
}
