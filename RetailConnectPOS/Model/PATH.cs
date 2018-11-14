namespace RetailConnectPOS.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PATH")]
    public partial class PATH
    {
        [StringLength(50)]
        public string DLSDIPATH { get; set; }

        [StringLength(50)]
        public string ULSDIPATH { get; set; }

        [Key]
        [Column(Order = 0)]
        public bool HQ { get; set; }

        [Key]
        [Column(Order = 1)]
        public bool WAREHOUSE { get; set; }

        [Key]
        [Column(Order = 2)]
        public bool SHELF { get; set; }

        [Key]
        [Column(Order = 3)]
        public bool CHGPRDNAME { get; set; }

        [Key]
        [Column(Order = 4)]
        public bool CHGCOSTPRICE { get; set; }

        [Key]
        [Column(Order = 5)]
        public bool CTLPOAUTHORISER { get; set; }

        [Key]
        [Column(Order = 6)]
        public bool CTLPOFOCQTY { get; set; }

        [Key]
        [Column(Order = 7)]
        public bool CTLPOQTY { get; set; }

        [Key]
        [Column(Order = 8)]
        public bool CTLGRQTY { get; set; }

        [Key]
        [Column(Order = 9)]
        public bool CTLSHELFQTY { get; set; }

        public int? CTLPOPHLVL { get; set; }

        public int? CTLROPHLVL { get; set; }

        [Key]
        [Column(Order = 10)]
        public bool CTLGRCOST { get; set; }

        [Key]
        [Column(Order = 11)]
        public bool IBTOUTINTERF { get; set; }

        [Key]
        [Column(Order = 12)]
        public bool GRINTERF { get; set; }

        [Key]
        [Column(Order = 13)]
        public bool IBTININTERF { get; set; }

        [Key]
        [Column(Order = 14)]
        public bool WSINTERF { get; set; }

        [Key]
        [Column(Order = 15)]
        public bool PRICETYPE { get; set; }

        [Key]
        [Column(Order = 16)]
        public bool POTOVPC { get; set; }

        [Key]
        [Column(Order = 17)]
        public bool POTYPE { get; set; }

        [Key]
        [Column(Order = 18)]
        public bool CASEIDCURR { get; set; }

        [StringLength(1)]
        public string MEMBERTYPE { get; set; }

        [StringLength(50)]
        public string FTPSFRSOU { get; set; }

        [StringLength(50)]
        public string FTPSTODES { get; set; }

        [StringLength(50)]
        public string FTPRFRSOU { get; set; }

        [StringLength(50)]
        public string FTPRTODES { get; set; }

        [StringLength(15)]
        public string LBLPARENT { get; set; }

        [StringLength(15)]
        public string LBLCHILD { get; set; }

        public int? BACKUPNO { get; set; }

        [Key]
        [Column(Order = 19)]
        public bool UPDATEPRICE { get; set; }

        [StringLength(50)]
        public string FTPSERVER { get; set; }

        [StringLength(50)]
        public string FTPID { get; set; }

        [StringLength(50)]
        public string FTPPASSWORD { get; set; }

        public double? RECEIPT2AMT { get; set; }

        [StringLength(50)]
        public string POSOU { get; set; }

        [StringLength(50)]
        public string PODES { get; set; }

        [StringLength(50)]
        public string POSOUBCK { get; set; }

        [StringLength(50)]
        public string PODESBCK { get; set; }

        [StringLength(50)]
        public string POFTPGET { get; set; }

        [StringLength(50)]
        public string POFTPPUT { get; set; }

        [StringLength(50)]
        public string COLLRPTSOU { get; set; }

        [StringLength(50)]
        public string COLLRPTSOUBCK { get; set; }

        [StringLength(50)]
        public string COLLRPTFTPPUT { get; set; }

        public double? MPSPOINT { get; set; }

        public double? MPSDOLLAR { get; set; }

        public double? MPRPOINT { get; set; }

        public double? MPRDOLLAR { get; set; }

        public DateTime? MPDATE { get; set; }

        [StringLength(10)]
        public string CURRENCYSIGN { get; set; }

        [StringLength(50)]
        public string RPTPATH { get; set; }

        [StringLength(50)]
        public string TRANSFEROUT { get; set; }

        [StringLength(50)]
        public string TRANSFERIN { get; set; }

        public double? BPRINTERTYPE { get; set; }

        public double? MINPURCHASE { get; set; }

        public double? CCPERCENT { get; set; }

        [Key]
        [Column(Order = 20)]
        public bool CON_TIQTY { get; set; }

        [Key]
        [Column(Order = 21)]
        public bool BSTANDALONE { get; set; }

        [Key]
        [Column(Order = 22)]
        public bool MEMBERONLY { get; set; }

        [Key]
        [Column(Order = 23)]
        public bool CUSTOMBCSCRIPT { get; set; }

        [Key]
        [Column(Order = 24)]
        public bool TI_DATE_INHERIT { get; set; }

        [Key]
        [Column(Order = 25)]
        public bool TO_ONBEHALF { get; set; }

        [Key]
        [Column(Order = 26)]
        public bool DO { get; set; }

        [StringLength(50)]
        public string DOSendPath { get; set; }

        [StringLength(50)]
        public string DORecPath { get; set; }

        public bool? CASE_QTY { get; set; }

        public bool? CRM_REDEMP { get; set; }

        public bool? FOLLOW_HQ_PRICE { get; set; }

        [StringLength(250)]
        public string CUSTOM_TO_STR_1 { get; set; }

        [StringLength(250)]
        public string CUSTOM_TO_STR_2 { get; set; }

        public bool? CALCCRM { get; set; }

        public DateTime? GSTDEPLOYDATE { get; set; }

        public bool? FOLLOW_HQ_COST { get; set; }
    }
}
