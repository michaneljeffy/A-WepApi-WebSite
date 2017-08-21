namespace RedBox.Models.RedBox
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("fans_online2.data_laneige_statistic")]
    public partial class data_laneige_statistic
    {
        [Column(TypeName = "uint")]
        public long id { get; set; }

        public int laneige_id { get; set; }

        [Required]
        [StringLength(255)]
        public string machine_code { get; set; }

        [Required]
        [StringLength(255)]
        public string out_trade_code { get; set; }

        public int status { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime created_at { get; set; }
    }
}
