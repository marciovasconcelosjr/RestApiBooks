using System.Collections.Generic;
using WebApplication1.Data.VO;
using WebApplication1.Model;

namespace WebApplication1.Business
{
    public interface IBooksBusiness
    {
        BooksVO Create(BooksVO books);
        BooksVO FindByID(long id);
        List<BooksVO> FindAll();
        BooksVO Update(BooksVO person);
        void Delete(long id);
    }
}
