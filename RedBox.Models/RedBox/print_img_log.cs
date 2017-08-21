namespace RedBox.Models.RedBox
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("fans_online2.print_img_log")]
    public partial class print_img_log
    {
        public int id { get; set; }

        public int? uid { get; set; }

        [Required]
        [StringLength(100)]
        public string machine_code { get; set; }

        [Required]
        [StringLength(255)]
        public string img_url { get; set; }

        [StringLength(100)]
        public string request_host { get; set; }

        public int? photo_key { get; set; }

        [StringLength(255)]
        public string extra { get; set; }

        public int created_at { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime? updated_at { get; set; }

        [Column(TypeName = "timestamp")]
        public DateTime? deleted_at { get; set; }
    }
}
