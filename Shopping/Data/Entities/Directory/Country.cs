using System.ComponentModel.DataAnnotations;

namespace Shopping.Data.Entities.Directory
{
    public class Country
    {
        public int Id { get; set; }

        [Display(Name = "Pais")]
        [MaxLength(50, ErrorMessage = "El campo {0} debe tener maximo {1} caracteres.")]
        [Required(ErrorMessage = " El campo {0} es obligatorio.")]
        public string Name { get; set; }

        /// <summary>
        /// Obtiene o establece un valor que indica si se permite la facturación en este país
        /// </summary>
        public bool AllowsBilling { get; set; }

        /// <summary>
        /// Obtiene o establece un valor que indica si se permite el envío a este país
        /// </summary>
        public bool AllowsShipping { get; set; }

        /// <summary>
        /// Obtiene o establece el código ISO de dos letras
        /// </summary>
        [Display(Name = "Código ISO")]
        [MaxLength(2)]
        [MinLength(2)]
        public string TwoLetterIsoCode { get; set; }


        /// <summary>
        /// Obtiene o establece el código ISO de tres letras
        /// </summary>
        [Display(Name = "Código ISO")]
        [MaxLength(3)]
        [MinLength(3)]
        public string ThreeLetterIsoCode { get; set; }

        /// <summary>
        /// Gets or sets the numeric ISO code
        /// </summary>
        [Display(Name = "Código ISO")]
        public int NumericIsoCode { get; set; }
    }
}
