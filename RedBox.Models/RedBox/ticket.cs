namespace RedBox.Models.RedBox
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("fans_online2.ticket")]
    public partial class ticket
    {
        public int id { get; set; }

        public int user_id { get; set; }

        public int? operate_user_id { get; set; }

        [StringLength(255)]
        public string contact { get; set; }

        [Required]
        [StringLength(255)]
        public string code { get; set; }

        public int box_id { get; set; }

        public int? state { get; set; }

        [StringLength(64)]
        public string title { get; set; }

        [StringLength(255)]
        public string description { get; set; }

        [StringLength(1024)]
        public string pics { get; set; }

        [Required]
        [StringLength(64)]
        public string ticket_type { get; set; }

        [StringLength(15)]
        public string ext1 { get; set; }

        [StringLength(15)]
        public string ext2 { get; set; }

        [StringLength(15)]
        public string ext3 { get; set; }

        public int? created_at { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime updated_at { get; set; }

        [Column(TypeName = "timestamp")]
        public DateTime? deleted_at { get; set; }
    }
}
