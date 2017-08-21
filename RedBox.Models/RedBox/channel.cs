namespace RedBox.Models.RedBox
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("fans_online2.channel")]
    public partial class channel
    {
        public int id { get; set; }

        [Required]
        [StringLength(255)]
        public string name { get; set; }

        [Required]
        [StringLength(255)]
        public string password { get; set; }

        [StringLength(50)]
        public string nick_name { get; set; }

        [StringLength(255)]
        public string mobile { get; set; }

        [Column(TypeName = "uint")]
        public long channel_type { get; set; }

        [Column(TypeName = "uint")]
        public long authorize { get; set; }

        [Column(TypeName = "uint")]
        public long? pid { get; set; }

        public int? created_at { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime? updated_at { get; set; }

        [Column(TypeName = "timestamp")]
        public DateTime? deleted_at { get; set; }

        [StringLength(255)]
        public string account_number { get; set; }

        public int? settlement_price { get; set; }

        public int? is_evolvable { get; set; }

        public int? primary_id { get; set; }

        public int? secondary_id { get; set; }

        public int? tertiary_id { get; set; }

        [StringLength(255)]
        public string role { get; set; }

        public int? level { get; set; }

        [StringLength(64)]
        public string corp_open_id { get; set; }

        [StringLength(64)]
        public string remember_token { get; set; }
    }
}
