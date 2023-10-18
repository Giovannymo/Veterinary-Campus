
namespace Domain.Entities;

    public class Pet : BaseEntity
    {
        public string Name {get;set;}
        public DateOnly DayOfBirth {get;set;}
        public int IdOwnerFk {get;set;}
        public Owner Owner {get;set;}
        public int IdRaceFk {get;set;}
        public Race Race {get;set;}


        
        
    }
