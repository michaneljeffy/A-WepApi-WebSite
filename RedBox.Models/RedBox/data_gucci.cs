namespace RedBox.Models.RedBox
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("fans_online2.data_gucci")]
    public partial class data_gucci
    {
        public int id { get; set; }

        [StringLength(50)]
        public string name { get; set; }

        [StringLength(20)]
        public string mobile { get; set; }

        public int? created_at { get; set; }

        [StringLength(2048)]
        public string extra { get; set; }
    }
}
