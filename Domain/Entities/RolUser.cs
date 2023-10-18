
namespace Domain.Entities;

    public class RolUser : BaseEntity
    {
        public int IdRolFk {get;set;}
        public Rol Rol {get;set;}
        public int IdUserFk {get;set;}
        public User User {get;set;}
        
    }
