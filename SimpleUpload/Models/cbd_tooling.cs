namespace SimpleUpload.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class cbd_tooling
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

        [StringLength(8)]
        public string bottomid { get; set; }

        [StringLength(8)]
        public string upperid { get; set; }

        [StringLength(2)]
        public string max_month { get; set; }

        [Column(TypeName = "date")]
        public DateTime? validfrom { get; set; }

        [Column(TypeName = "date")]
        public DateTime? validto { get; set; }

        [StringLength(8)]
        public string tool_kind { get; set; }

        [StringLength(8)]
        public string tool_number { get; set; }

        [StringLength(15)]
        public string tool_subnumber { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(100)]
        public string moldtype { get; set; }

        [StringLength(200)]
        public string details { get; set; }

        [StringLength(10)]
        public string tool_create_seas { get; set; }

        [StringLength(50)]
        public string stat_size_group { get; set; }

        [StringLength(10)]
        public string own_fact { get; set; }

        [StringLength(10)]
        public string mold_shop { get; set; }

        public decimal? pr_byday { get; set; }

        public decimal? unit_price_usd { get; set; }

        public decimal? qty { get; set; }

        public decimal? tot_mold_cost_usd { get; set; }

        public decimal? amort_paid { get; set; }

        [StringLength(20)]
        public string comp_mm { get; set; }

        [StringLength(20)]
        public string comp_bv { get; set; }

        public int? remain_base_vol { get; set; }

        [Column(TypeName = "date")]
        public DateTime? comp_amortvalid_from { get; set; }

        [Column(TypeName = "date")]
        public DateTime? comp_amortvalid_to { get; set; }

        public decimal? da_cost_usd { get; set; }

        [Column(TypeName = "date")]
        public DateTime? pr_amortremoved_from { get; set; }

        [StringLength(200)]
        public string comment { get; set; }

        [Required]
        [StringLength(10)]
        public string inusr { get; set; }

        public DateTime indt { get; set; }

        [StringLength(10)]
        public string upusr { get; set; }

        public DateTime? updt { get; set; }
    }
}
