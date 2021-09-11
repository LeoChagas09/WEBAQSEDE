using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WEBAQSEDE.Models.Dominio
{
    public class Produto
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DisplayName("ID")]
        public int id { get; set; }

        [StringLength(35)]
        [DisplayName("Nome Produto")]
        [Required(ErrorMessage = "Campo Nome Produto  é obrigatorio")]
        public string Nome { get; set; }

        [StringLength(60)]
        [Display(Name = "Classificação")]
        [Required(ErrorMessage = "Campo Classificação é obrigatorio")]
        public string Classificacao { get; set; }

        [StringLength(35)]
        [DisplayName("Quantidade")]
        [Required(ErrorMessage = "Campo Quantidade é obrigatorio")]
        public int Quantidade { get; set; }

        [StringLength(35)]
        [DisplayName("Valor do Produto")]
        [Required(ErrorMessage = "Campo Valor é obrigatorio")]
        public float Valor { get; set; }
    }
}
