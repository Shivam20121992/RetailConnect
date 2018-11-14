namespace RetailConnectPOS.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RIREASON")]
    public partial class RIREASON
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(3)]
        public string RIREASONCODE { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(40)]
        public string RIREASONDESC { get; set; }
    }
}
