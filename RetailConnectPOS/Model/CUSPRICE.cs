namespace RetailConnectPOS.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CUSPRICE")]
    public partial class CUSPRICE
    {
        public DateTime? CREATEDATE { get; set; }

        [StringLength(12)]
        public string STORECODE { get; set; }

        [StringLength(30)]
        public string CUSTOMERCODE { get; set; }

        [StringLength(7)]
        public string PRDCODE { get; set; }

        public double? PRICE { get; set; }

        public DateTime? MODIFYDATE { get; set; }

        [Key]
        public bool POSTED { get; set; }

        public DateTime? UPLOADDATE { get; set; }
    }
}
