namespace RedBox.Models.RedBox
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("fans_online2.xmas_assist")]
    public partial class xmas_assist
    {
        public int id { get; set; }

        public int participator_id { get; set; }

        public int assistant_id { get; set; }

        [Required]
        [StringLength(32)]
        public string machine_id { get; set; }

        public int created_at { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime updated_at { get; set; }
    }
}
