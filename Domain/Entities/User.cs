
namespace Domain.Entities;

    public class User : BaseEntity
    {
        public string Name {get; set;}
        public string Email {get; set;}
        public string Password {get; set;}
        public ICollection<RolUser> RolUsers {get;set;}
        public ICollection<Rol> Roles { get; set; } = new HashSet<Rol>();
        public ICollection<RefreshToken> RefreshTokens { get; set; } = new HashSet<RefreshToken>();

        
    }
