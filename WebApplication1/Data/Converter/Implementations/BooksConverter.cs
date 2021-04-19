using System.Collections.Generic;
using System.Linq;
using WebApplication1.Data.Converter.Contract;
using WebApplication1.Data.VO;
using WebApplication1.Model;

namespace WebApplication1.Data.Converter.Implementations
{
    public class BooksConverter : IParser<BooksVO, Books>, IParser<Books, BooksVO>
    {
        public Books Parse(BooksVO origin)
        {
            if (origin == null) return null;
            return new Books
            {
                Id = origin.Id,
                Titulo = origin.Titulo,
                Autor = origin.Autor,
                Preço = origin.Preço,
                Launch_date = origin.Launch_date
            };
        }

        public BooksVO Parse(Books origin)
        {
            if (origin == null) return null;
            return new BooksVO
            {
                Id = origin.Id,
                Titulo = origin.Titulo,
                Autor = origin.Autor,
                Preço = origin.Preço,
                Launch_date = origin.Launch_date
            };
        }

        public List<Books> Parse(List<BooksVO> origin)
        {
            if (origin == null) return null;
            return origin.Select(item => Parse(item)).ToList();
        }

        public List<BooksVO> Parse(List<Books> origin)
        {
            if (origin == null) return null;
            return origin.Select(item => Parse(item)).ToList();
        }

    }
}
