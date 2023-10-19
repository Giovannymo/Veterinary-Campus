
namespace Domain.Entities;

    public class Supplier : BaseEntity
    {
        public string Name {get;set;}
        public string Address {get;set;}
        public string Telephone {get;set;}
        public ICollection<MedicineSupplier> MedicineSuppliers {get;set;}
        public ICollection<Medicine> Medicines = new HashSet<Medicine>();//Cuando es many to many

    }
