namespace RetailConnectPOS.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SHIFTLOG")]
    public partial class SHIFTLOG
    {
        [Key]
        [Column(Order = 0)]
        public int AUDITNO { get; set; }

        [StringLength(10)]
        public string STORECODE { get; set; }

        [StringLength(12)]
        public string COUNTERCODE { get; set; }

        public DateTime? CREATEDATE { get; set; }

        public short? SHIFT { get; set; }

        [StringLength(10)]
        public string SHIFT_ID { get; set; }

        public DateTime? SHIFT_OPEN { get; set; }

        public DateTime? SHIFT_CLOSE { get; set; }

        [Key]
        [Column(Order = 1)]
        public bool POSTED { get; set; }

        public DateTime? DOWNLOADDATE2 { get; set; }

        public int? PSNO { get; set; }
    }
}
