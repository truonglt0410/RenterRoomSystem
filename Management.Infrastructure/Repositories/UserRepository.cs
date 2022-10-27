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

namespace Management.Infrastructure.Repositories
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        private readonly IConfiguration _configuration;
        public UserRepository(DbFactory dbFactory, IConfiguration configuration) : base(dbFactory)
        {
            _configuration = configuration;
        }

        public async Task<List<User>>  NewUser()
        {
            //var cs = "Server=ec2-44-205-41-76.compute-1.amazonaws.com:5432;Database=dcdkpi6gugrah6;User Id=zwclfpyangxmti;Password=a6d6d59e578940b819a5cb8f1b50878c44eab3d2f2b4d0bfec06b77753a5e7e7;";
            var cs = this._configuration.GetConnectionString("ManagementConnection");
            var con = new NpgsqlConnection(cs);
            con.Open();
            var sql = "select * from account";
            var cmd = new NpgsqlCommand(sql, con);
            var render = await cmd.ExecuteReaderAsync();
            List<User> users = new List<User>();
            while (await render.ReadAsync())
            {
                User user = new User();
                user.Id = (int)render["id"];
                user.UserName = render["username"] as string;
                user.Password = render["password"] as string;
                user.Email = render["email"] as string;
                user.Id_role = (int)render["id_role"];
                users.Add(user);
            }
            con.Close();
            return users;
        }
        public async Task<User> GetUserbyId(int id)
        {
            //var cs = "Server=ec2-44-205-41-76.compute-1.amazonaws.com:5432;Database=dcdkpi6gugrah6;User Id=zwclfpyangxmti;Password=a6d6d59e578940b819a5cb8f1b50878c44eab3d2f2b4d0bfec06b77753a5e7e7;";
            var cs = this._configuration.GetConnectionString("ManagementConnection");
            var con = new NpgsqlConnection(cs);
            con.Open();
            var sql = "select * from account where id =" + id;
            var cmd = new NpgsqlCommand(sql, con);
            var render = await cmd.ExecuteReaderAsync();
            //List<User> users = new List<User>();
            User user = new User();
            while (await render.ReadAsync())
            {
               
                user.Id = (int)render["id"];
                user.UserName = render["username"] as string;
                user.Password = render["password"] as string;
                user.Email = render["email"] as string;
                user.Id_role = (int)render["id_role"];
               
            }
            con.Close();
            return user;
        }
        public async Task<User> GetUserbyName(string name)
        {
            //var cs = "Server=ec2-44-205-41-76.compute-1.amazonaws.com:5432;Database=dcdkpi6gugrah6;User Id=zwclfpyangxmti;Password=a6d6d59e578940b819a5cb8f1b50878c44eab3d2f2b4d0bfec06b77753a5e7e7;";
            var cs = this._configuration.GetConnectionString("ManagementConnection");
            var con = new NpgsqlConnection(cs);
            con.Open();
            var sql = "select * from account where username ='"+ name +"'";
            var cmd = new NpgsqlCommand(sql, con);
            var render = await cmd.ExecuteReaderAsync();
            //List<User> users = new List<User>();
            User user = new User();
            while (await render.ReadAsync())
            {

                user.Id = (int)render["id"];
                user.UserName = render["username"] as string;
                user.Password = render["password"] as string;
                user.Email = render["email"] as string;
                user.Id_role = (int)render["id_role"];

            }
            con.Close();
            return user;
        }
        public User getAccount(string userName)
        {
            //var cs = "Server=ec2-44-205-41-76.compute-1.amazonaws.com:5432;Database=dcdkpi6gugrah6;User Id=zwclfpyangxmti;Password=a6d6d59e578940b819a5cb8f1b50878c44eab3d2f2b4d0bfec06b77753a5e7e7;";
            var cs = this._configuration.GetConnectionString("ManagementConnection");
            var con = new NpgsqlConnection(cs);
            con.Open();
            var sql = "select * from account";
            var cmd = new NpgsqlCommand(sql, con);
            var user = cmd.ExecuteScalar();
            return new User();
        }



    }
}
