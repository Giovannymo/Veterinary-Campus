
namespace Domain.Entities;

    public class Medicine : BaseEntity
    {
        public string Name {get;set;}
        public int Stock {get;set;}
        public double Price {get;set;}
        public int IdLaboratoryFk {get;set;}
        public Laboratory Laboratory {get;set;}
        public ICollection<DetailMovement> DetailMovements {get;set;}
        public ICollection<MedicalTreatment> MedicalTreatments {get;set;}
        public ICollection<MedicineSupplier> MedicineSuppliers {get;set;}
        public ICollection<Supplier> Suppliers = new HashSet<Supplier>();//Cuando es many to many

        

    }
