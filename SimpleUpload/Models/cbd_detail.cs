namespace SimpleUpload.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class cbd_detail
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

        [StringLength(20)]
        public string kind { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(50)]
        public string part { get; set; }

        [StringLength(200)]
        public string partna { get; set; }

        [StringLength(50)]
        public string addition { get; set; }

        [StringLength(100)]
        public string supp { get; set; }

        [StringLength(200)]
        public string material { get; set; }

        [StringLength(200)]
        public string mat_thickness { get; set; }

        [StringLength(50)]
        public string uom { get; set; }

        public decimal? cif { get; set; }

        public decimal? mat_yield { get; set; }

        public decimal? mat_yield_eff { get; set; }

        public decimal? loss_perc { get; set; }

        public decimal? calc_size_perc { get; set; }

        public decimal? gross_yield { get; set; }

        public decimal? mat_fob_usd { get; set; }

        public decimal? fob_bypair_usd { get; set; }

        [Required]
        [StringLength(10)]
        public string inusr { get; set; }

        public DateTime indt { get; set; }

        [StringLength(10)]
        public string upusr { get; set; }

        public DateTime? updt { get; set; }
    }
}
