namespace RedBox.Models.RedBox
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("fans_online2.statistic_printer")]
    public partial class statistic_printer
    {
        public int id { get; set; }

        public int user_id { get; set; }

        [Required]
        [StringLength(255)]
        public string official_account_code { get; set; }

        [Required]
        [StringLength(255)]
        public string machine_code { get; set; }

        [Required]
        [StringLength(255)]
        public string out_trade_code { get; set; }

        public int status { get; set; }

        public int? operation_id { get; set; }

        public int printer_status { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime created_at { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime updated_at { get; set; }

        public int? coin { get; set; }

        [StringLength(16777215)]
        public string extra_data { get; set; }

        public double? print_count { get; set; }
    }
}
