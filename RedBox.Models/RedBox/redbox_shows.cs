namespace RedBox.Models.RedBox
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("fans_online2.redbox_shows")]
    public partial class redbox_shows
    {
        [Column(TypeName = "uint")]
        public long id { get; set; }

        [Column(TypeName = "uint")]
        public long redbox_id { get; set; }

        [Required]
        [StringLength(512)]
        public string shows_qrcode { get; set; }

        [Required]
        [StringLength(512)]
        public string shows_paper_print { get; set; }

        [Required]
        [StringLength(2048)]
        public string shows_control_part { get; set; }

        [Required]
        [StringLength(2048)]
        public string shows_screen { get; set; }

        [Required]
        [StringLength(1024)]
        public string shows_scroll { get; set; }

        public int created_at { get; set; }

        [Column(TypeName = "timestamp")]
        public DateTime updated_at { get; set; }

        [Column(TypeName = "timestamp")]
        public DateTime? deleted_at { get; set; }

        public sbyte redbox_shows_type { get; set; }

        public sbyte child_type { get; set; }

        [StringLength(2048)]
        public string third_screen { get; set; }
    }
}
