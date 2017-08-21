namespace RedBox.Models.RedBox
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("fans_online2.redbox")]
    public partial class redbox
    {
        public int id { get; set; }

        public int redbox_type { get; set; }

        public int cid { get; set; }

        public int status { get; set; }

        [Required]
        [StringLength(255)]
        public string maid { get; set; }

        [Required]
        [StringLength(255)]
        public string code { get; set; }

        public int city { get; set; }

        [Required]
        [StringLength(255)]
        public string location { get; set; }

        [Required]
        [StringLength(10)]
        public string network_state { get; set; }

        public bool has_printer { get; set; }

        [Required]
        [StringLength(255)]
        public string ip { get; set; }

        [Required]
        [StringLength(255)]
        public string sdcard { get; set; }

        public int priting_emulate_time { get; set; }

        [Required]
        [StringLength(255)]
        public string version { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(4)]
        public string shutdown_hour { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(4)]
        public string shutdown_min { get; set; }

        [Required]
        [StringLength(255)]
        public string halt_remark { get; set; }

        public int is_show_code { get; set; }

        [Required]
        [StringLength(255)]
        public string con_tel { get; set; }

        public sbyte print_size { get; set; }

        [Column(TypeName = "uint")]
        public long pp_offset { get; set; }

        [Required]
        [StringLength(11)]
        public string shutdown_time { get; set; }

        public sbyte shows_update { get; set; }

        public int can_update { get; set; }

        [StringLength(50)]
        public string tv_name { get; set; }

        [StringLength(100)]
        public string tv_password { get; set; }

        [StringLength(50)]
        public string ver_type { get; set; }

        [Column(TypeName = "text")]
        [Required]
        [StringLength(65535)]
        public string ma_info { get; set; }

        [Required]
        [StringLength(10)]
        public string remote_id { get; set; }

        public int created_at { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime updated_at { get; set; }

        [Column(TypeName = "timestamp")]
        public DateTime? deleted_at { get; set; }

        [Column(TypeName = "timestamp")]
        public DateTime onlined_at { get; set; }

        [StringLength(255)]
        public string child_cid { get; set; }

        [StringLength(255)]
        public string looklike { get; set; }

        public int? location_type { get; set; }

        [StringLength(16777215)]
        public string extra_data { get; set; }

        [Required]
        [StringLength(10)]
        public string boot_time { get; set; }

        public sbyte? print_mode { get; set; }

        public int? owner_cid { get; set; }

        public int? secondary_cid { get; set; }

        public int? tertiary_cid { get; set; }
    }
}
