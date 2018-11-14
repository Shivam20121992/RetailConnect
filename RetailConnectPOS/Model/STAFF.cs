namespace RetailConnectPOS.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("STAFF")]
    public partial class STAFF
    {
        [Key]
        [StringLength(30)]
        public string STAFFCODE { get; set; }

        [StringLength(40)]
        public string STAFFNAME { get; set; }

        [StringLength(20)]
        public string IC { get; set; }

        public DateTime? BDATE { get; set; }

        [StringLength(1)]
        public string MARITALCODE { get; set; }

        [StringLength(1)]
        public string SEXCODE { get; set; }

        [StringLength(40)]
        public string ADDRESS1 { get; set; }

        [StringLength(40)]
        public string ADDRESS2 { get; set; }

        [StringLength(40)]
        public string ADDRESS3 { get; set; }

        [StringLength(15)]
        public string HTEL { get; set; }

        [StringLength(15)]
        public string OTEL { get; set; }

        [StringLength(15)]
        public string MTEL { get; set; }

        [StringLength(15)]
        public string FAX { get; set; }

        [StringLength(50)]
        public string EMAIL { get; set; }

        public DateTime? CREATEDATE { get; set; }

        public DateTime? JDATE { get; set; }

        public DateTime? MODIFYDATE { get; set; }

        public int? SALESPERSON { get; set; }

        public double? COMMISION { get; set; }

        [StringLength(50)]
        public string REMARK { get; set; }

        [StringLength(40)]
        public string OCCU { get; set; }

        public int? UPDATENO { get; set; }

        public DateTime? UPDATEDATE { get; set; }
    }
}
