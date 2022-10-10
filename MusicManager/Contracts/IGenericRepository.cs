using Microsoft.AspNetCore.Mvc.Rendering;
using MusicManager.Enumerations;

namespace MusicManager.Contracts
{
    public interface IGenericRepository<T> where T : class
    {
        Task<T> GetAsync(int? id);
        Task DeleteAsync(int id);
        Task<bool> Exists(int id);
        bool HasEntries(SelectType type);
        SelectList? GetSelectListAsync(SelectType type, List<int>? values = null, int? value = null);
    }
}
