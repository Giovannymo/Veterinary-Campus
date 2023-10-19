
using Domain.Entities;

namespace VeterinaryApi.Dtos;

    public class CitationDto
    {
        public int Id {get;set;}
        public DateTime Date {get;set;}
        public DateTime Time {get;set;}
        public Veterinarian Veterinarian {get;set;}
        
        
    }
