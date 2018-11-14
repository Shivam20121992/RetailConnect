namespace RetailConnectPOS.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("INVNUM")]
    public partial class INVNUM
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int NUMBER { get; set; }
    }
}
