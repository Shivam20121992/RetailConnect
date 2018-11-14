namespace RetailConnectPOS.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class OPENDRAWER_LOG
    {
        public DateTime? CREATEDATE { get; set; }

        [Key]
        [StringLength(50)]
        public string USERID { get; set; }

        public DateTime? TIMESTAMP { get; set; }

        [StringLength(50)]
        public string REMARK { get; set; }

        [StringLength(50)]
        public string AUTHID { get; set; }
    }
}
