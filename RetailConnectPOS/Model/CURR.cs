namespace RetailConnectPOS.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CURR")]
    public partial class CURR
    {
        [Key]
        [StringLength(50)]
        public string FR_COUNTRY { get; set; }

        [MaxLength(50)]
        public byte[] TO_COUNTRY { get; set; }

        [StringLength(50)]
        public string DESCRIPTION { get; set; }

        [StringLength(10)]
        public string FR_RATE { get; set; }

        public int? TO_RATE { get; set; }

        [StringLength(50)]
        public string ACTIVE { get; set; }
    }
}
