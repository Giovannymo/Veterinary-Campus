
namespace Domain.Entities;

    public class Race : BaseEntity
    {
        public string Name {get;set;}
        public int IdSpecieFk {get;set;}
        public Species Species {get;set;}
        public ICollection<Pet> Pets {get;set;}

        
    }
