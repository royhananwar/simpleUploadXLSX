namespace SimpleUpload.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class manuf_excell_detail
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

        [Key]
        [Column(Order = 3)]
        [StringLength(50)]
        public string tech { get; set; }

        [StringLength(50)]
        public string descr { get; set; }

        [StringLength(10)]
        public string levl { get; set; }

        public decimal? cost_bypairs_usd { get; set; }

        [Required]
        [StringLength(10)]
        public string inusr { get; set; }

        public DateTime indt { get; set; }

        [StringLength(10)]
        public string upusr { get; set; }

        public DateTime? updt { get; set; }
    }
}
