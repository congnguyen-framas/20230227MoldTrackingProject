using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MoldTracking.InterfacesModels;
using RestEase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoldTracking.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseController<TId, T> : ControllerBase, IRepository<TId, T> where T : class
    {
        protected IRepository<TId, T> _baseRepo;

        public BaseController(IRepository<TId, T> repository)
        {
            _baseRepo = repository;
        }

        [HttpGet(ApiRoutes.Get)]
        public Task<Result<T>> Get(TId id)
        {
            return _baseRepo.Get(id);
        }

        [HttpGet(ApiRoutes.GetAll)]
        public Task<Result<List<T>>> GetAll()
        {
            return _baseRepo.GetAll();
        }

        [HttpPost(ApiRoutes.Insert)]
        public Task<Result<string>> Insert([Body] T model)
        {
            return _baseRepo.Insert(model);
        }

        [HttpPut(ApiRoutes.Update)]
        public Task<Result<string>> Update([Body] T model)
        {
            return _baseRepo.Update(model);
        }
    }
}
