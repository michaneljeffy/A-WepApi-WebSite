namespace RedBox.Models.RedBox
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("fans_online2.channel_machine")]
    public partial class channel_machine
    {
        public int id { get; set; }

        public int cid { get; set; }

        [Required]
        [StringLength(50)]
        public string machine_code { get; set; }

        public int created_at { get; set; }
    }
}
