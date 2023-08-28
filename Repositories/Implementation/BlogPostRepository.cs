using AngularProject.Data;
using AngularProject.Models.Domain;
using AngularProject.Repositories.Interface;
using Microsoft.EntityFrameworkCore;

namespace AngularProject.Repositories.Implementation
{
    public class BlogPostRepository : IBlogPostRepository
    {
        private readonly ApplicationDbContext dbContext;

        public BlogPostRepository(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<BlogPost> CreateAsync(BlogPost blogPost)
        {
            await dbContext.BlogPosts.AddAsync(blogPost);
            await dbContext.SaveChangesAsync();

            return blogPost;
        }

        //public async Task<Category?> DeleteAsync(Guid id)
        //{
        //    var existingCategory = await dbContext.Categories.FirstOrDefaultAsync(x => x.Id == id);

        //    if(existingCategory is null)
        //    {
        //        return null;
        //    }

        //    dbContext.Categories.Remove(existingCategory);
        //    dbContext.SaveChangesAsync(true);
        //    return existingCategory;
        //}

        public async Task<IEnumerable<BlogPost>> GetAllAsync()
        {
            return await dbContext.BlogPosts.ToListAsync();
        }

        //public async Task<Category?> GetById(Guid id)
        //{
        //    return await dbContext.Categories.FirstOrDefaultAsync(x => x.Id.Equals(id));
        //}
        //public async Task<Category> UpdateAsync(Category category)
        //{

        //    var existingCategory = await dbContext.Categories.FirstOrDefaultAsync(item => item.Id == category.Id);

        //    if(existingCategory != null)
        //    {
        //        dbContext.Entry(existingCategory).CurrentValues.SetValues(category);
        //        await dbContext.SaveChangesAsync();
        //        return category;
        //    }

        //    return null;
        //}

    }
}
