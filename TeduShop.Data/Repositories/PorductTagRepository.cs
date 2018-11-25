using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeduShop.Data.Infratructure;
using TeduShop.Model.Models;

namespace TeduShop.Data.Repositories
{
    public class PorductTagRepository : RepositoryBase<ProductTag>, IProductTagRepository
    {
        public PorductTagRepository(IDbFactory dbFactory) : base(dbFactory)
        {

        }
    }

    public interface IProductTagRepository
    {
    }
}
