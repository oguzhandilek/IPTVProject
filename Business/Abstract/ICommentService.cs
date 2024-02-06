using Entities;

namespace Business.Abstract;

public interface ICommentService
{
    Task<IQueryable<Comment>> GetAllAsync();
    Task<Comment> GetByIdAsync(int id);
    Task<Comment> AddAsync(Comment comment);
    Task<Comment> UpdateAsync(Comment comment);
    Task<Comment> DeleteAsync(int id);
}

