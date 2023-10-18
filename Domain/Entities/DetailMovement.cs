
namespace Domain.Entities;

    public class DetailMovement : BaseEntity
    {
        public int Stock {get;set;}
        public double Price {get;set;}
        public int IdMedicineMovementFk {get;set;}
        public MedicineMovement MedicineMovement {get;set;}
        public int IdMedicineFk {get;set;}
        public Medicine Medicine {get;set;}

        
    }
