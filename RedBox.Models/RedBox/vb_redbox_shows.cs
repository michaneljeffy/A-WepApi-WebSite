namespace RedBox.Models.RedBox
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("fans_online2.vb_redbox_shows")]
    public partial class vb_redbox_shows
    {
        public int id { get; set; }

        [StringLength(2048)]
        public string third_screen { get; set; }

        public sbyte? vb_redbox_shows_type { get; set; }

        [StringLength(2000)]
        public string shows_screen_adv { get; set; }

        [Required]
        [StringLength(1000)]
        public string shows_control_adv { get; set; }

        [StringLength(500)]
        public string shows_scroll { get; set; }

        [StringLength(200)]
        public string show_qrcode { get; set; }

        [StringLength(200)]
        public string show_paper_print { get; set; }

        public int redbox_id { get; set; }

        public int? created_at { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime? updated_at { get; set; }

        [Column(TypeName = "timestamp")]
        public DateTime? deleted_at { get; set; }
    }
}
