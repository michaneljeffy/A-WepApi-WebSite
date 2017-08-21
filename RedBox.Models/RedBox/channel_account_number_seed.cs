namespace RedBox.Models.RedBox
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("fans_online2.channel_account_number_seed")]
    public partial class channel_account_number_seed
    {
        public int id { get; set; }

        [Column(TypeName = "uint")]
        public long? cid { get; set; }

        [StringLength(255)]
        public string role { get; set; }

        public int? level { get; set; }

        public int? sequence { get; set; }

        [Column(TypeName = "timestamp")]
        public DateTime? deleted_at { get; set; }

        public int created_at { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime? updated_at { get; set; }
    }
}
