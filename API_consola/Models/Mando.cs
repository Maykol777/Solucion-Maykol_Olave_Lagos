namespace API_consola.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Mandos")]
    public partial class Mando
    {
        public int id { get; set; }

        [Required]
        [StringLength(25)]
        public string marca { get; set; }

        [Required]
        [StringLength(25)]
        public string modelo { get; set; }

        [Required]
        [StringLength(50)]
        public string compatibilidad { get; set; }

        public int precio { get; set; }

        public int stock { get; set; }
    }
}
