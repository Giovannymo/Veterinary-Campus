


namespace Domain.Interfaces;
    public interface IUnityOfWork
    {
    ICitation Citations {get;}

    Task<int> SaveAsync();

}
