namespace RedBox.Models.RedBox
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("fans_online2.print_coupon")]
    public partial class print_coupon
    {
        [Column(TypeName = "uint")]
        public long id { get; set; }

        [Column(TypeName = "uint")]
        public long? user_id { get; set; }

        [Column(TypeName = "uint")]
        public long print_num { get; set; }

        [Column(TypeName = "uint")]
        public long status { get; set; }

        [Column(TypeName = "uint")]
        public long expired_at { get; set; }

        public int? created_at { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime? updated_at { get; set; }

        [Column(TypeName = "timestamp")]
        public DateTime? deleted_at { get; set; }
    }
}
