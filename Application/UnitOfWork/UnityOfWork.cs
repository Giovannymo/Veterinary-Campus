
using Application.Repository;
using Domain.Interfaces;
using Persistence;

namespace Application.UnitOfWork;

public class UnityOfWork : IUnityOfWork, IDisposable
{
    private readonly VeterinaryContext _context;
    private CitationRepository _citations;

    public UnityOfWork(VeterinaryContext context)
    {
        _context = context;
    }
    public ICitation Citations{
        get
        {
            if (_citations == null)
            {
                _citations = new CitationRepository(_context);
            }
            return _citations;
        }

    }

    public async Task<int> SaveAsync()
    {
        return await _context.SaveChangesAsync();
    }

    public void Dispose()
    {
        _context.Dispose();
    }
}
