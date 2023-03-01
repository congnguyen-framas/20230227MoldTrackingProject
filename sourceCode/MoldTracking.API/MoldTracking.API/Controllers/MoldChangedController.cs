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
    public class MoldChangedController : BaseController<Guid, tblMoldChangedInfoModel>, IMoldChangedService
    {
        IMoldChangedService _moldChangedService;

        public MoldChangedController(IMoldChangedService moldChangedService) : base(moldChangedService)
        {
            _moldChangedService = moldChangedService;
        }
    }
}
