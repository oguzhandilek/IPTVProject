using Business.Abstract;
using DataAccess.Abstract;
using Entities;

namespace Business.Concrete;

public class CommentManager : ICommentService
{
    private readonly ICommentDal _commentDal;

    public CommentManager(ICommentDal commentDal)
    {
        _commentDal = commentDal;
    }

    public async Task<Comment> AddAsync(Comment comment)
    {
       await _commentDal.AddAsync(comment);
        return null;
    }

    public async Task<Comment> DeleteAsync(int id)
    {
        await _commentDal.DeleteAsync(id);
        return null;
    }

    public async Task<IQueryable<Comment>> GetAllAsync()
    {
        return await _commentDal.GetAllAsync();
    }

    public async Task<Comment> GetByIdAsync(int id)
    {
      return await _commentDal.GetAsync(p=>p.Id == id);
    }

    public async Task<Comment> UpdateAsync(Comment comment)
    {
        await _commentDal.UpdateAsync(comment);
        return null;
    }
}

