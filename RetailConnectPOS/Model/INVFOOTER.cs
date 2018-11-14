namespace RetailConnectPOS.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("INVFOOTER")]
    public partial class INVFOOTER
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int INVNUM { get; set; }

        public int? CASH { get; set; }

        public int? CHANGE { get; set; }

        public int? TDISC { get; set; }

        public DateTime? CREATEDATE { get; set; }

        public int? SECTION { get; set; }

        public int? EXTRACHANGE1 { get; set; }

        public int? EXTRACHANGE2 { get; set; }

        public int? VAR1 { get; set; }

        public int? VAR2 { get; set; }

        public int? GST { get; set; }

        public int? VAR3 { get; set; }

        public int? VAR4 { get; set; }

        public int? VAR5 { get; set; }

        public int? VAR6 { get; set; }

        public int? VAR7 { get; set; }
    }
}
