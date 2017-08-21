namespace RedBox.Models.RedBox
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("fans_online2.preference_printer")]
    public partial class preference_printer
    {
        public int id { get; set; }

        [Required]
        [StringLength(255)]
        public string machine_code { get; set; }

        [Required]
        [StringLength(255)]
        public string official_account_code { get; set; }

        [Required]
        [StringLength(255)]
        public string area { get; set; }

        public int status { get; set; }

        public int is_top { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime? created_at { get; set; }

        [Column(TypeName = "timestamp")]
        public DateTime? updated_at { get; set; }

        public bool? is_lock { get; set; }

        public int? display_order { get; set; }
    }
}
