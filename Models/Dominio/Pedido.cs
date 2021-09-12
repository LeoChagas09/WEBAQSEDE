using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WEBAQSEDE.Models.Dominio
{
    public class Pedido
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DisplayName("ID")]
        public int id { get; set; }

        [StringLength(35)]
        [DisplayName("Nome Cliente")]
        [Required(ErrorMessage = "Campo Nome do Cliente é obrigatorio")]
        public Cliente Nome_Cliente { get; set; }

        [StringLength(60)]
        [Display(Name = "Endereço")]
        [Required(ErrorMessage = "Campo Endereco é obrigatorio")]
        public Cliente Endereco { get; set; }

        [StringLength(35)]
        [DisplayName("Nome do Produto")]
        [Required(ErrorMessage = "Campo Nome do Produto é obrigatorio")]
        public Produto Nome_Produto { get; set; }

        [StringLength(35)]
        [DisplayName("Valor do Produto")]
        [Required(ErrorMessage = "Campo Valor do Produto é obrigatorio")]
        public Produto Valor_Produto { get; set; }

        [StringLength(35)]
        [DisplayName("Quantidade")]
        [Required(ErrorMessage = "Campo Quantidade é obrigatorio")]
        public int Quantidade { get; set; }

        /*[Display(Name = "Valor Total")]
        [NotMapped]
        public float ValorTotal { 
            get (float) (Quantidade * Valor_Produto);}

        [StringLength(35)]
        [DisplayName("Previsão de Entrega")]
        [Required(ErrorMessage = "Campo Previsão Entrega é obrigatorio")]
        public string PrevisaoEntrega { get; set; }*/

    }
}
