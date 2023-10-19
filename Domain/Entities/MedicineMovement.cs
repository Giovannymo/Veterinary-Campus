
namespace Domain.Entities;

    public class MedicineMovement : BaseEntity
    {
        public int Stock {get;set;} 
        public DateTime DateMovement {get;set;} 
        public int IdTypeMovement {get;set;}
        public TypeMovement TypeMovement {get;set;}
        public ICollection<DetailMovement> DetailMovements {get;set;}
        

        
    }
