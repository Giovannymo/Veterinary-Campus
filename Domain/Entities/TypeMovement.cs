
namespace Domain.Entities;

    public class TypeMovement : BaseEntity
    {
        public string Description {get;set;}

        public ICollection<MedicineMovement> MedicineMovements {get;set;}
        
    }


