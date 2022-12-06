using System.ComponentModel.DataAnnotations;

namespace EldenLabs.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Celular { get; set; }
        public string Password { get; set; }
        public string Token { get; set; }
        public string Role { get; set; }
        public ICollection<Ruta> Rutas { get; set; }
    }
}
