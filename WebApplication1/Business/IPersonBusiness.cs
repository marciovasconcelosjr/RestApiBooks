using System.Collections.Generic;
using WebApplication1.Data.VO;
using WebApplication1.Model;

namespace WebApplication1.Business
{
    public interface IPersonBusiness
    {
        PersonVO Create(PersonVO person);
        PersonVO FindByID(long id);
        List<PersonVO> FindAll();
        PersonVO Update(PersonVO person);
        void Delete(long id);

    }
}
