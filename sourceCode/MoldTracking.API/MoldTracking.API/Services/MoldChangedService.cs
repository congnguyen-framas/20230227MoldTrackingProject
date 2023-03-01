using MoldTracking.InterfacesModels;
using RestEase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoldTracking.API
{
    public class MoldChangedService : IMoldChangedService
    {
        public async Task<Result<tblMoldChangedInfoModel>> Get(Guid id)
        {
            try
            {
                var resultData = new tblMoldChangedInfoModel() { MachineCode = "123", MachineName = "May 1" };
                return await Result<tblMoldChangedInfoModel>.SuccessAsync(resultData);
            }
            catch (Exception ex)
            {
                return await Result<tblMoldChangedInfoModel>.FailAsync(ex.Message);
            }
        }

        public Task<Result<List<tblMoldChangedInfoModel>>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Result<int>> Insert([Body] tblMoldChangedInfoModel model)
        {
            throw new NotImplementedException();
        }

        public Task<Result<int>> Update([Body] tblMoldChangedInfoModel model)
        {
            throw new NotImplementedException();
        }
    }
}
