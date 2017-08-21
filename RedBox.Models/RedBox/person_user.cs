namespace RedBox.Models.RedBox
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("fans_online2.person_user")]
    public partial class person_user
    {
        [Column(TypeName = "uint")]
        public long id { get; set; }

        [Required]
        [StringLength(50)]
        public string code { get; set; }

        [Required]
        [StringLength(255)]
        public string username { get; set; }

        public int created_at { get; set; }

        public int is_use { get; set; }

        [Required]
        [StringLength(20)]
        public string other_uid { get; set; }
    }
}
