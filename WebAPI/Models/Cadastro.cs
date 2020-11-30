using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPI.Models
{
    public class Cadastro
    {
        [Key]
        public int  ID_funcionario { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string Nome { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string Endereco { get; set; }

        [Column(TypeName = "varchar(10)")]
        public string Nascimento { get; set; }

        [Column(TypeName = "varchar(20)")]
        public string Salario { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string Genero { get; set; }
    }
}
