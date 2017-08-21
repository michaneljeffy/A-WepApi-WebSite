namespace RedBox.Models.RedBox
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("fans_online2.qmyx_device")]
    public partial class qmyx_device
    {
        [Column(TypeName = "ubigint")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal id { get; set; }

        [Required]
        [StringLength(50)]
        public string device_code { get; set; }

        [Required]
        [StringLength(255)]
        public string device_name { get; set; }

        [Required]
        [StringLength(20)]
        public string city { get; set; }

        [Required]
        [StringLength(255)]
        public string market { get; set; }

        public bool is_enable { get; set; }

        public bool is_delete { get; set; }

        [Column(TypeName = "uint")]
        public long created_at { get; set; }

        [Column(TypeName = "timestamp")]
        public DateTime? deleted_at { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime updated_at { get; set; }
    }
}
