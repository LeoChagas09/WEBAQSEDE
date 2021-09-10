using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WEBAQSEDE.Models.Dominio
{
    public class Estabelecimento
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DisplayName("ID")]
        public int Id { get; set; }

        [StringLength(35, ErrorMessage = "Não aceita Nome com mais de 35 dígitos")]
        [DisplayName("Nome")]
        [Required(ErrorMessage = "Campo nome do estabelecimento é obrigatório")]
        public string Nome { get; set; }

        [StringLength(25, ErrorMessage = "Não aceita CNPJ com mais de 25 dígitos")]
        [DisplayName("CNPJ")]
        [Required(ErrorMessage = "Campo CPF do estabelecimento é obrigatório")]
        public string CNPJ { get; set; }

        [StringLength(35, ErrorMessage = "Não aceita Email com mais de 35 dígitos")]
        [DisplayName("Email")]
        [Required(ErrorMessage = "Campo Email do estabelecimento é obrigatório")]
        public string Email { get; set; }

        [StringLength(20, ErrorMessage = "Não aceita CEP com mais de 20 dígitos")]
        [DisplayName("CEP")]
        [Required(ErrorMessage = "Campo CEP do estabelecimento é obrigatório")]
        public string CEP { get; set; }

        [StringLength(35, ErrorMessage = "Não aceita cidade com mais de 35 dígitos")]
        [DisplayName("Cidade")]
        [Required(ErrorMessage = "Campo Cidade do estabelecimento é obrigatório")]
        public string Cidade { get; set; }

        [StringLength(20, ErrorMessage = "Não aceita Nome com mais de 20 dígitos")]
        [DisplayName("Telefone")]
        [Required(ErrorMessage = "Campo telefone do estabelecimento é obrigatório")]
        public string Telefone { get; set; }

        [StringLength(35, ErrorMessage = "Não aceita endereço com mais de 35 dígitos")]
        [DisplayName("Endereço")]
        [Required(ErrorMessage = "Campo endereço do estabelecimento é obrigatório")]
        public string Endereco { get; set; }
    }
}
