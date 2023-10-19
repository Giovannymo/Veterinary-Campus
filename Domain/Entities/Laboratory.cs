
namespace Domain.Entities;

    public class Laboratory : BaseEntity
    {
        public string Name {get;set;}
        public string Address {get;set;}
        public string Telephone {get;set;}
        public ICollection<Medicine> Medicines {get;set;}

        
    }
