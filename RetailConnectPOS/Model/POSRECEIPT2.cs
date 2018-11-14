namespace RetailConnectPOS.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class POSRECEIPT2
    {
        [Key]
        public int SNO { get; set; }

        [StringLength(40)]
        public string RECEIPTMSG { get; set; }
    }
}
