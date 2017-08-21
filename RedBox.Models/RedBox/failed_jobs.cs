namespace RedBox.Models.RedBox
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("fans_online2.failed_jobs")]
    public partial class failed_jobs
    {
        [Column(TypeName = "uint")]
        public long id { get; set; }

        [Column(TypeName = "text")]
        [StringLength(65535)]
        public string connection { get; set; }

        [Column(TypeName = "text")]
        [StringLength(65535)]
        public string queue { get; set; }

        [StringLength(1073741823)]
        public string payload { get; set; }

        [Column(TypeName = "timestamp")]
        public DateTime? failed_at { get; set; }
    }
}
