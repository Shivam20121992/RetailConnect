namespace RetailConnectPOS.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DEFPRICE")]
    public partial class DEFPRICE
    {
        [Key]
        [Column("DEFPRICE")]
        public bool DEFPRICE1 { get; set; }
    }
}
