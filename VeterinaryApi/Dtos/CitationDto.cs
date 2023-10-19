
using Domain.Entities;

namespace VeterinaryApi.Dtos;

    public class CitationDto
    {
        public int Id {get;set;}
        public DateTime Date {get;set;}
        public DateTime Time {get;set;}
        public string Reason {get;set;}
        public int IdVeterinarianFk {get;set;}
        
        
    }
