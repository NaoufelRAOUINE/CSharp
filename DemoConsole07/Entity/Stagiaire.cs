namespace DemoConsole07
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Stagiaire
    {
        [Key]
        public long IdStagiaire { get; set; }

        [Required]
        [StringLength(50)]
        public string NomStagiaire { get; set; }

        [Required]
        [StringLength(70)]
        public string Adresse { get; set; }

        [Required]
        [StringLength(20)]
        public string Ville { get; set; }

        [Required]
        [StringLength(10)]
        public string CP { get; set; }

        [Required]
        [StringLength(30)]
        public string Pays { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [StringLength(8)]
        public string Pseudo { get; set; }

        public byte? Age { get; set; }

        public byte? Specialite { get; set; }

        public virtual Specialite Specialite1 { get; set; }
    }
}
