namespace RedBox.Models.RedBox
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("fans_online2.payment_print_refund")]
    public partial class payment_print_refund
    {
        public int id { get; set; }

        public int user_id { get; set; }

        [Required]
        [StringLength(255)]
        public string machine_code { get; set; }

        public int payment_print_id { get; set; }

        [Required]
        [StringLength(255)]
        public string tip { get; set; }

        [Required]
        [StringLength(20)]
        public string mobile { get; set; }

        [Required]
        [StringLength(2048)]
        public string content { get; set; }

        [Required]
        [StringLength(16777215)]
        public string extra_data { get; set; }

        [Column(TypeName = "timestamp")]
        public DateTime deleted_at { get; set; }

        public int created_at { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime updated_at { get; set; }

        [Required]
        [StringLength(16777215)]
        public string img_url { get; set; }

        public sbyte problem_type { get; set; }

        public int money { get; set; }

        [Required]
        [StringLength(255)]
        public string alipay_account { get; set; }
    }
}
