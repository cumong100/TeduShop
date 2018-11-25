using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeduShop.Data.Infratructure;
using TeduShop.Model.Models;

namespace TeduShop.Data.Repositories
{
    public interface IFooterRepository
    {
        IEnumerable<Footer> GetContentById(string id);
    }
    public class FooterRepository : RepositoryBase<Footer>, IFooterRepository
    {
        public FooterRepository(IDbFactory dbFactory) : base(dbFactory)
        {

        }
        public IEnumerable<Footer> GetContentById(string id)
        {
            return this.DbContext.Footers.Where(f => f.ID == id);
        }
    }


}
