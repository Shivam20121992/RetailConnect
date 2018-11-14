namespace RetailConnectPOS.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("STORE")]
    public partial class STORE
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string STORECODE { get; set; }

        [StringLength(40)]
        public string STORENAME { get; set; }

        [StringLength(20)]
        public string SHORTNAME { get; set; }

        [StringLength(3)]
        public string CURRCODE { get; set; }

        [StringLength(40)]
        public string ADDRESS1 { get; set; }

        [StringLength(40)]
        public string ADDRESS2 { get; set; }

        [StringLength(40)]
        public string ADDRESS3 { get; set; }

        [StringLength(10)]
        public string ZIP { get; set; }

        [StringLength(10)]
        public string TELEPHONE1 { get; set; }

        [StringLength(10)]
        public string FAX1 { get; set; }

        [StringLength(50)]
        public string COMEMAIL { get; set; }

        [StringLength(50)]
        public string CONTACT { get; set; }

        [StringLength(50)]
        public string PEMAIL { get; set; }

        public DateTime? DELDATE { get; set; }

        [StringLength(10)]
        public string TELEPHONE2 { get; set; }

        [StringLength(10)]
        public string FAX2 { get; set; }

        [StringLength(3)]
        public string COUNTRYCODE { get; set; }

        [StringLength(20)]
        public string COMPY_REG { get; set; }

        [StringLength(5)]
        public string TELAREA1 { get; set; }

        [StringLength(5)]
        public string TELAREA2 { get; set; }

        [StringLength(5)]
        public string FAXAREA1 { get; set; }

        [StringLength(5)]
        public string FAXAREA2 { get; set; }

        [StringLength(20)]
        public string VATNO { get; set; }

        [StringLength(25)]
        public string CITY { get; set; }

        public int? PRIMARY { get; set; }

        public DateTime? CREATEDATE { get; set; }

        public DateTime? MODIFYDATE { get; set; }

        [StringLength(25)]
        public string STATE { get; set; }

        [StringLength(1)]
        public string STATUSCODE { get; set; }

        public int? UPDATENO { get; set; }

        public DateTime? UPDATEDATE { get; set; }

        [Key]
        [Column(Order = 1)]
        public bool SENDINTERFACE { get; set; }

        [StringLength(50)]
        public string LOCATIONID { get; set; }

        [StringLength(30)]
        public string AREACODE { get; set; }
    }
}
