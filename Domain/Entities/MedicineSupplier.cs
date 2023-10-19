
namespace Domain.Entities;

    public class MedicineSupplier : BaseEntity
    {
        public int IdMedicineFk {get;set;}
        public Medicine Medicine {get;set;}
        public int IdSupplierFk {get;set;}
        public Supplier Supplier {get;set;}    
    }
