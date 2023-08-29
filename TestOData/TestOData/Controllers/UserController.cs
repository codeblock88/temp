using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using Microsoft.AspNetCore.OData.Routing.Controllers;
using TestOData.Context;
using TestOData.Models;

namespace TestOData.Controllers
{
    public class UserController : ODataController
    {
        private readonly SqliteDbContext _sqliteDbContext;

        public UserController(SqliteDbContext sqliteDbContext)
        {
            _sqliteDbContext = sqliteDbContext;
        }


        [HttpGet]
        [EnableQuery]
        public IQueryable<User> Get()
        {
            IQueryable<User> data = _sqliteDbContext.Users.AsQueryable();
            return data;
        }
    }
}
