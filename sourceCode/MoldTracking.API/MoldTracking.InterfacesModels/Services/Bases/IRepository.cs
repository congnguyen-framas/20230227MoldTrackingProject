using RestEase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoldTracking.InterfacesModels
{
    public interface IRepository<TId, T> where T : class
    {
        [Get(ApiRoutes.Get)]
        Task<Result<T>> Get(TId id);

        [Get(ApiRoutes.GetAll)]
        Task<Result<List<T>>> GetAll();

        [Post(ApiRoutes.Insert)]
        Task<Result<int>> Insert([Body] T model);

        [Put(ApiRoutes.Update)]
        Task<Result<int>> Update([Body] T model);
    }
}
