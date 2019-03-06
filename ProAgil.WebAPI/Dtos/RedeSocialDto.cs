using System.ComponentModel.DataAnnotations;

namespace ProAgil.WebAPI.Dtos
{
    public class RedeSocialDto
    {        
        public int Id { get; set; }
        
        [Required (ErrorMessage="O Campo {0} é Obrigatório")]
        public string Nome { get; set; }

        [Required (ErrorMessage="O Campo {0} é Obrigatório")]
        public string URL { get; set; }
    }
}