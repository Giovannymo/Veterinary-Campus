
namespace Domain.Entities;

    public class MedicineMovement : BaseEntity
    {
        public int Stock {get;set;} 
        public DateOnly DateMovement {get;set;} 
        public int IdTypeMovement {get;set;}
        public TypeMovement TypeMovement {get;set;}

        
    }
