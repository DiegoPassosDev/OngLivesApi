using System.Text.Json.Serialization;

namespace ONGLIVES.API.Entidades
{
    public class Voluntario : Base
    {
        // public int Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string CPF { get; set; }
        public DateTime DataAniversario { get; set; }
        public string Escolaridade { get; set; }
        public string Genero { get; set; }
        public string Email { get; set; }
        public Endereco Endereco { get; set; }
    }
}