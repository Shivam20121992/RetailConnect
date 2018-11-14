namespace RetailConnectPOS.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PRICETYPE")]
    public partial class PRICETYPE
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string PRICETYPECODE { get; set; }

        [StringLength(50)]
        public string PRICETYPEDESC { get; set; }

        [Key]
        [Column(Order = 1)]
        public bool DISC { get; set; }

        [Key]
        [Column(Order = 2)]
        public bool MEMBER { get; set; }

        [Key]
        [Column(Order = 3)]
        public bool STAFF { get; set; }

        public double? DISC_P { get; set; }
    }
}
