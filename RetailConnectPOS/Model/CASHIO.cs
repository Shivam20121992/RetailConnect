namespace RetailConnectPOS.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CASHIO")]
    public partial class CASHIO
    {
        [Key]
        [StringLength(50)]
        public string USERID { get; set; }

        public DateTime? DATE { get; set; }

        public DateTime? TIME { get; set; }

        public int? TYPE { get; set; }

        [StringLength(50)]
        public string DESCRIPTION { get; set; }

        public int? AMOUNT { get; set; }

        public int? SHIFT { get; set; }

        [StringLength(50)]
        public string SHIFT_ID { get; set; }

        public int? AMOUNT2 { get; set; }

        public int? EXCHRATE { get; set; }
    }
}
