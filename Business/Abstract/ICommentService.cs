using Entities;

namespace Business.Abstract;

public interface ICommentService
{
    Task<IQueryable<Comment>> GetAll();
    Task<Comment> GetByIdAsync(int id);
    Task<Comment> AddAsync(Comment comment);
    Task<Comment> UpdateAsync(Comment comment);
    Task<Comment> DeleteAsync(int id);
}

