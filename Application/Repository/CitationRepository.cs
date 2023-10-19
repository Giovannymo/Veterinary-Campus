
using Domain.Entities;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Repository;

public class CitationRepository : GenericRepository<Citation>, ICitation
{
    private readonly VeterinaryContext _context;    
    public CitationRepository(VeterinaryContext context) : base(context)
    {
        _context = context;
    }

    public override async Task<IEnumerable<Citation>> GetAllAsync(){
        return await _context.Citations
                    .Include(p => p.Veterinarian)
                    .ToListAsync();
    }

}
