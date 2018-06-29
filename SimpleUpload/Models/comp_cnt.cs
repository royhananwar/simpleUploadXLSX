namespace SimpleUpload.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class comp_cnt
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

        public decimal cp_lea { get; set; }

        public decimal cp_nonlea { get; set; }

        public decimal stitch_piec { get; set; }

        public decimal st { get; set; }

        public decimal second_ass { get; set; }

        public decimal treatment { get; set; }

        public decimal bottom_piec { get; set; }

        [Required]
        [StringLength(10)]
        public string inusr { get; set; }

        public DateTime indt { get; set; }

        [StringLength(10)]
        public string upusr { get; set; }

        public DateTime? updt { get; set; }
    }
}
