namespace RedBox.Models.RedBox
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("fans_online2.printer_operation")]
    public partial class printer_operation
    {
        [Column(TypeName = "uint")]
        public long id { get; set; }

        public int user_id { get; set; }

        [Required]
        [StringLength(20)]
        public string official_account_code { get; set; }

        [Required]
        [StringLength(255)]
        public string machine_code { get; set; }

        public double? total_count { get; set; }

        public double? left_count { get; set; }

        public sbyte period_printer { get; set; }

        [Column(TypeName = "timestamp")]
        public DateTime? fan_at { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime? created_at { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime? updated_at { get; set; }

        [StringLength(255)]
        public string print_source { get; set; }
    }
}
