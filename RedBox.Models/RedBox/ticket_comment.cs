namespace RedBox.Models.RedBox
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("fans_online2.ticket_comment")]
    public partial class ticket_comment
    {
        public int id { get; set; }

        public int ticket_id { get; set; }

        public int user_id { get; set; }

        [StringLength(1024)]
        public string content { get; set; }

        [StringLength(1024)]
        public string images { get; set; }

        public int? created_at { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime updated_at { get; set; }

        [Column(TypeName = "timestamp")]
        public DateTime? deleted_at { get; set; }
    }
}
