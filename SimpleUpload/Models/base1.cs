namespace SimpleUpload.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class base1
    {
        public int id { get; set; }

        [StringLength(10)]
        public string factory { get; set; }

        [StringLength(10)]
        public string cal_size { get; set; }
    }
}
