namespace RedBox.Models.RedBox
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("fans_online2.data_promo_statistic")]
    public partial class data_promo_statistic
    {
        [Column(TypeName = "uint")]
        public long id { get; set; }

        public int promo_id { get; set; }

        [Required]
        [StringLength(255)]
        public string machine_code { get; set; }

        [Required]
        [StringLength(255)]
        public string out_trade_code { get; set; }

        public int status { get; set; }

        public int printer_status { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime created_at { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime updated_at { get; set; }
    }
}
