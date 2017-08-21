namespace RedBox.Models.RedBox
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("fans_online2.users")]
    public partial class users
    {
        [Column(TypeName = "uint")]
        public long id { get; set; }

        [Required]
        [StringLength(255)]
        public string name { get; set; }

        [StringLength(255)]
        public string avatar { get; set; }

        [StringLength(255)]
        public string email { get; set; }

        [StringLength(255)]
        public string password { get; set; }

        [Required]
        [StringLength(255)]
        public string wechat_openid { get; set; }

        [Required]
        [StringLength(255)]
        public string machine_code { get; set; }

        [StringLength(100)]
        public string remember_token { get; set; }

        public int? sex { get; set; }

        [StringLength(100)]
        public string city { get; set; }

        [StringLength(100)]
        public string province { get; set; }

        [StringLength(100)]
        public string country { get; set; }

        public int print_type { get; set; }

        [Column(TypeName = "timestamp")]
        public DateTime? deleted_at { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime? created_at { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime? updated_at { get; set; }

        public int money { get; set; }

        public int? total_print_count { get; set; }

        [StringLength(16777215)]
        public string extra_data { get; set; }
    }
}
