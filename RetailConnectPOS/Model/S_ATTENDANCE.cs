namespace RetailConnectPOS.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class S_ATTENDANCE
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int LASTID { get; set; }

        public DateTime? CREATEDATE { get; set; }

        [StringLength(50)]
        public string USERID { get; set; }

        public DateTime? C_IN { get; set; }

        public DateTime? C_OUT { get; set; }

        [StringLength(50)]
        public string POSTED { get; set; }

        [StringLength(50)]
        public string TYPE { get; set; }
    }
}
