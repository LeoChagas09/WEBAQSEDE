using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WEBAQSEDE.Models.Dominio
{
    public class Entrega
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DisplayName("ID")]
        public int id { get; set; }

        [DisplayName("ID Pedido")]
        public Pedido id_pedido { get; set; }

        [StringLength(35)]
        [DisplayName("Nome Entregador")]
        [Required(ErrorMessage = "Campo Nome Entregador  é obrigatorio")]
        public Entregador NomeEntregador { get; set; }

        [StringLength(35)]
        [DisplayName("Horario Entrega")]
        [Required(ErrorMessage = "Campo Horario Entrega é obrigatorio")]
        public string Horario_Entrega { get; set; }
    }
}
