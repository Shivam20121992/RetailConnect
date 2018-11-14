namespace RetailConnectPOS.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UPC")]
    public partial class UPC
    {
        [Column("UPC")]
        [StringLength(18)]
        public string UPC1 { get; set; }

        [Key]
        [StringLength(7)]
        public string PRDCODE { get; set; }

        public DateTime? CREATEDATE { get; set; }

        [StringLength(1)]
        public string STATUSCODE { get; set; }

        public DateTime? DELDATE { get; set; }

        public int? UPDATENO { get; set; }

        public DateTime? UPDATEDATE { get; set; }

        [StringLength(50)]
        public string REMARK { get; set; }
    }
}
