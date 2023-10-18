
namespace Domain.Entities;

    public class Medicine : BaseEntity
    {
        public string Name {get;set;}
        public int Stock {get;set;}
        public double Price {get;set;}
        public int IdLaboratoryFk {get;set;}
        public Laboratory Laboratory {get;set;}
        
        

    }
