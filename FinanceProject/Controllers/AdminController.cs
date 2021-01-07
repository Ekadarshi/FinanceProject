using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using FinanceProject.Models;
using System.Web.Http.Cors;

namespace FinanceProject.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class AdminController : ApiController
    {
        //GET api/admin/UserDetails
        [HttpGet]
        public HttpResponseMessage UserDetails()
        {
            using (project1Entities db=new project1Entities())
            {
                var data = from user in db.UserTables where user.validation == "ToValidate" select user;
                List<UserTable> users = data.ToList();
                return Request.CreateResponse(HttpStatusCode.OK, users);
            }
        }
    }
}
