namespace RetailConnectPOS.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class VAT_IN
    {
        [Key]
        [StringLength(5)]
        public string VI_CODE { get; set; }

        public double? VI_PERCENT { get; set; }

        [StringLength(15)]
        public string ACC_CODE { get; set; }

        public bool? PURCHASE { get; set; }
    }
}
