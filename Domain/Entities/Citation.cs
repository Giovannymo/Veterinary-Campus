
namespace Domain.Entities;

    public class Citation : BaseEntity
    {
        public string Reason {get;set;}
        public DateOnly Date {get;set;}
        public DateTime Time {get;set;}
        public int IdVeterinarianFk {get;set;}
        public Veterinarian Veterinarian {get;set;}
        

        
    }
