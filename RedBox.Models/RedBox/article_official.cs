namespace RedBox.Models.RedBox
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("fans_online2.article_official")]
    public partial class article_official
    {
        [Column(TypeName = "uint")]
        public long id { get; set; }

        [Required]
        [StringLength(50)]
        public string official_account_code { get; set; }

        [Required]
        [StringLength(200)]
        public string article_url { get; set; }

        public int created_at { get; set; }

        [Column(TypeName = "timestamp")]
        public DateTime? deleted_at { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime updated_at { get; set; }
    }
}
