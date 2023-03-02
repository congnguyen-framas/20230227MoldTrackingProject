using Dapper;
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

        public async Task<Result<List<tblMoldChangedInfoModel>>> GetAll()
        {
            try
            {
                using (var connection = GlobalVariable.GetDbDogeWhProvider())
                {
                    var result = connection.Query<tblMoldChangedInfoModel>("sp_mtTblMoldChangedGets").ToList();

                    if (result.Count > 0)
                    {
                        return await Result<List<tblMoldChangedInfoModel>>.SuccessAsync(result);
                    }
                    else
                    {
                        return await Result<List<tblMoldChangedInfoModel>>.FailAsync("Query error or empty data.");
                    }
                }
            }
            catch (Exception ex)
            {
                return await Result<List<tblMoldChangedInfoModel>>.FailAsync(ex.Message);
            }
        }

        public async Task<Result<string>> Insert([Body] tblMoldChangedInfoModel model)
        {
            try
            {
                var para = new DynamicParameters();
                para.Add("@MachineCode", model.MachineCode);
                para.Add("@MachineName", model.MachineName);
                para.Add("@MoldCode", model.MoldCode);
                para.Add("@MoldName", model.MoldName);
                para.Add("@ItemCode", model.ItemCode);
                para.Add("@ItemName", model.ItemName);
                para.Add("@ColorCode", model.ColorCode);
                para.Add("@ColorName", model.ColorName);
                para.Add("@SizeCode", model.SizeCode);
                para.Add("@SizeName", model.SizeName);
                para.Add("@ReceiveTime", model.ReceiveTime);
                para.Add("@ActualReceiveTime", model.ActualReceiveTime);
                para.Add("@CreatedById", model.CreatedById);
                para.Add("@CreatedByName", model.CreatedByName);

                using (var connection = GlobalVariable.GetDbDogeWhProvider())
                {
                    var result = connection.Execute("sp_mtTblMoldChangedInfoInsert", para, commandType: System.Data.CommandType.StoredProcedure);

                    if (result > 0)
                    {
                        return await Result<string>.SuccessAsync("Insert successful.");
                    }
                    else
                    {
                        return await Result<string>.FailAsync("Insert fail.");
                    }
                }
            }
            catch (Exception ex)
            {
                return await Result<string>.FailAsync(ex.Message);
            }
        }

        public Task<Result<string>> Update([Body] tblMoldChangedInfoModel model)
        {
            throw new NotImplementedException();
        }
    }
}
