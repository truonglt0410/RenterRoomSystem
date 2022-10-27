using Management.Domain.Departments;
using Management.Domain.Interfaces;
using Management.Domain.Users;
using System;
using System.Collections.Generic;
using System.Text;
using Npgsql;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.Internal;
using Management.Domain.Base;
using Management.Domain.DataModel;
using Management.Domain.Buildings;

namespace Management.Infrastructure.Repositories
{
    public class BuildingRepository: IBuildingRepository
    {
        private readonly IConfiguration _configuration;
        public BuildingRepository(DbFactory dbFactory, IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public async Task<ResultDataModel> AddBuilding(BuildingModel model)
        {
            ResultDataModel resultDataModel = new ResultDataModel();
            try
            {
                var cs = this._configuration.GetConnectionString("ManagementConnection");
                var con = new NpgsqlConnection(cs);
                con.Open();
                var sql = "insert into Building values("+ model.Id + "," +
                    ""+model.Id_Account+"," +
                    "'"+model.Name+"'," +
                    "'"+model.Code_Address+"'," +
                    "'"+model.Image+"'," +
                    "'"+model.Description+"'," +
                    "'"+model.Utilites+"'," +
                    "'"+model.Rules+"')";
                var cmd = new NpgsqlCommand(sql, con);
                var render = await cmd.ExecuteNonQueryAsync();
                if (render > 0)
                {
                    resultDataModel.Status = "Ok";
                    resultDataModel.Messages = "Thêm thành công!";

                }
                else
                {
                    resultDataModel.Status = "Error";
                    resultDataModel.Messages = "Đã có lỗi xảy ra!";

                }    
                con.Close();
                
            }
            catch (Exception ex)
            {

                resultDataModel.Status = "Error";
                resultDataModel.Messages = ex.Message;
            }
            return resultDataModel;
        }
    }
}
