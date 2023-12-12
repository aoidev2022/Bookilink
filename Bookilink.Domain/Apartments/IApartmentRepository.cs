namespace Bookilink.Domain.Apartments
{
    internal interface IApartmentRepository
    {
        Task<Apartment> GetById(Guid id, CancellationToken cancellationToken = default);
        void AddApartmen(Apartment apartment);
    }
}
