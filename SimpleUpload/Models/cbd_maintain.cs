namespace SimpleUpload.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class cbd_maintain
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(7)]
        public string season { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short version { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(8)]
        public string art { get; set; }

        [StringLength(15)]
        public string pri_stage { get; set; }

        [Column(TypeName = "date")]
        public DateTime? validfrom { get; set; }

        [Column(TypeName = "date")]
        public DateTime? validto { get; set; }

        [StringLength(3)]
        public string pbtype { get; set; }

        [StringLength(3)]
        public string mwtype { get; set; }

        [StringLength(6)]
        public string sam_size { get; set; }

        [StringLength(6)]
        public string cal_size { get; set; }

        public decimal? upper_usd { get; set; }

        public decimal? sockliner_usd { get; set; }

        public decimal? insole_usd { get; set; }

        public decimal? bottom_usd { get; set; }

        public decimal? sundries_usd { get; set; }

        public decimal? packaging_usd { get; set; }

        public decimal? da_usd { get; set; }

        public decimal? fob_usd { get; set; }

        public decimal? labor_usd { get; set; }

        public decimal? oh_usd { get; set; }

        public short? labor { get; set; }

        public decimal? surcharge { get; set; }

        public decimal? reduction_usd { get; set; }

        [StringLength(7)]
        public string upperid { get; set; }

        [StringLength(7)]
        public string bottomid { get; set; }

        public int? uppervol { get; set; }

        public decimal? vol_adj_usd { get; set; }

        [StringLength(5)]
        public string tier { get; set; }

        public decimal? labor_rate { get; set; }

        public decimal? labor_ratio { get; set; }

        public decimal? overhead_rate { get; set; }

        public decimal? overhead_ratio { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(10)]
        public string inusr { get; set; }

        [Key]
        [Column(Order = 4)]
        public DateTime indt { get; set; }

        [StringLength(10)]
        public string upusr { get; set; }

        public DateTime? updt { get; set; }
    }
}
