using Microsoft.Extensions.Hosting;
using VTrivia.Model;

namespace VTrivia.Repository.IRepository
{
    public interface IAppUserRepository
    {
        IEnumerable<AppUser> GetAll();
        AppUser Get(string id);

        //IEnumerable<AppUser> GetAppUser(string id);
        AppUser Add(AppUser entity);
        void Remove(int id);

        AppUser Update(AppUser entity);
        void RemoveRange(IEnumerable<AppUser> entities);
    }
}
