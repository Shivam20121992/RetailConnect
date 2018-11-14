namespace RetailConnectPOS.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("COUNTER")]
    public partial class COUNTER
    {
        [Key]
        [MaxLength(50)]
        public byte[] COUNTERCODE { get; set; }
    }
}
