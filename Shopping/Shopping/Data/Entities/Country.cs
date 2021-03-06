using System.ComponentModel.DataAnnotations;

namespace Shopping.Data.Entities
{
    public class Country
    {
        public int Id { get; set; }

        [Display(Name = "País")]
        [MaxLength(50, ErrorMessage = "El campo {0} debe tener máximo {1} caractéres.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string Name { get; set; }
        public string Descripcion { get; set; }


        [Display(Name = "Departamentos/Estados")]
        public ICollection<State> States { get; set; }
        public int StatesNumber => States == null ? 0 : States.Count;
        

    }
}
