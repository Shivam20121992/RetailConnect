namespace RetailConnectPOS.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class POS
    {
        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string FIELD1 { get; set; }
    }
}
