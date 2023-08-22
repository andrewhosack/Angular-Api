using AngularProject.Models.Domain;

namespace AngularProject.Repositories.Interface
{
    public interface ICategoryRepository
    {
        Task<Category> CreateAsync(Category category);
    }
}
