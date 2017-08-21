namespace RedBox.Models.RedBox
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("fans_online2.users_money_log")]
    public partial class users_money_log
    {
        [Column(TypeName = "uint")]
        public long id { get; set; }

        public int user_id { get; set; }

        public int number { get; set; }

        [Required]
        [StringLength(20)]
        public string types { get; set; }

        public int created_at { get; set; }

        [Required]
        [StringLength(50)]
        public string code { get; set; }

        [Required]
        [StringLength(255)]
        public string data2 { get; set; }
    }
}
