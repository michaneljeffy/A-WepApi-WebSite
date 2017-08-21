namespace RedBox.Models.RedBox
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("fans_online2.data_coinprint")]
    public partial class data_coinprint
    {
        [Column(TypeName = "uint")]
        public long id { get; set; }

        public int user_id { get; set; }

        [Required]
        [StringLength(50)]
        public string machine_code { get; set; }

        public int created_at { get; set; }

        [StringLength(20)]
        public string location { get; set; }

        public int agent { get; set; }

        [StringLength(50)]
        public string agentname { get; set; }
    }
}
