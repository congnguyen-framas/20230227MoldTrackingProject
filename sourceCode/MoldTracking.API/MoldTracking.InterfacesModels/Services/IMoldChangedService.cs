using RestEase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoldTracking.InterfacesModels
{
    public interface IMoldChangedService:IRepoService,IRepository<Guid,tblMoldChangedInfoModel>
    {
    }
}
