namespace RetailConnectPOS.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("POSKEYCODE")]
    public partial class POSKEYCODE
    {
        [StringLength(50)]
        public string FUNCTIONCODE { get; set; }

        [Column("POSKEYCODE")]
        public int? POSKEYCODE1 { get; set; }

        [StringLength(50)]
        public string DESCRIPTION { get; set; }

        [StringLength(10)]
        public string KEYSIGN { get; set; }

        [Key]
        public bool PCONTROL { get; set; }
    }
}
