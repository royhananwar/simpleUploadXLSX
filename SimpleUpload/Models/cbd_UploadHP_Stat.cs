namespace SimpleUpload.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class cbd_UploadHP_Stat
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

        [Required]
        [StringLength(1)]
        public string up_hp_stat { get; set; }

        public DateTime indt { get; set; }

        public DateTime? uploaddt { get; set; }
    }
}
