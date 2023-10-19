
namespace Domain.Entities;

    public class Species : BaseEntity
    {
        public string Name {get;set;}
        public ICollection<Race> Races {get;set;}
        
    }
