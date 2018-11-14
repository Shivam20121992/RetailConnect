namespace RetailConnectPOS.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CCCharge")]
    public partial class CCCharge
    {
        [Key]
        [StringLength(7)]
        public string PRDCODE { get; set; }

        [StringLength(40)]
        public string PRDNAME { get; set; }

        public short? PERCENTAGE { get; set; }
    }
}
