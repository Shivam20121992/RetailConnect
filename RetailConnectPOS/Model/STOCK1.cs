namespace RetailConnectPOS.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("STOCKs")]
    public partial class STOCK1
    {
        [Key]
        [StringLength(7)]
        public string PRDCODE { get; set; }

        [StringLength(40)]
        public string PRDNAME { get; set; }

        public double? REGPRICE { get; set; }

        [StringLength(40)]
        public string ALTCODE { get; set; }

        [StringLength(10)]
        public string VATIN { get; set; }
    }
}
