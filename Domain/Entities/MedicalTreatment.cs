
namespace Domain.Entities;

public class MedicalTreatment : BaseEntity
{
    public int Dosage {get;set;}
    public DateOnly DateAdmin {get;set;}
    public string Observation {get;set;}
    public int IdCitationFk {get;set;}
    public Citation Citation {get;set;}
    public int IdMedicineFk {get;set;}
    public Medicine Medicine {get;set;}

        
}
