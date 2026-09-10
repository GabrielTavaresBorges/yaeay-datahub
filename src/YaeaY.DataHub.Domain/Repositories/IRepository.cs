using YaeaY.DataHub.Domain.Abstraction.Interfaces;

namespace YaeaY.DataHub.Domain.Repositories;

public interface IRepository<T> where T : IAggregateRoot { }
