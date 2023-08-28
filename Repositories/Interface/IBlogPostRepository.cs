using AngularProject.Models.Domain;

namespace AngularProject.Repositories.Interface
{
    public interface IBlogPostRepository
    {
        Task<BlogPost> CreateAsync(BlogPost blogPost);
        Task<IEnumerable<BlogPost>> GetAllAsync();
        //Task<Category?> GetById(Guid id);
        //Task<Category?> UpdateAsync(Category category);
        //Task<Category?> DeleteAsync(Guid id);
    }
}
