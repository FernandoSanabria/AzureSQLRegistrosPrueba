using System.ComponentModel.DataAnnotations;

namespace ApiAzureSQLRegistrosPrueba.Models
{
    public class Contacts
    {
        [Key]
        public int Identificador { get; set; }

        public string Nombre { get; set; }

        public string Email { get; set; }

        public int Telefono { get; set; }

    }
}