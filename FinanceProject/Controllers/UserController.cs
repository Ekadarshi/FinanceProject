using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using FinanceProject.Models;
namespace FinanceProject.Controllers
{
    public class UserController : ApiController
    {
        [HttpGet]
        public HttpResponseMessage CardDashBoard()
        {
            project1Entities db = new project1Entities();
            var data = from cd1 in db.CardDetails
                       select new
                       {
                           CardNumber = cd1.CardNumber,
                           Name = cd1.UserTable.Name,
                           Valid_Till = cd1.ValidTill.ToString("MM/yy"),
                           Card_Type = cd1.CardType
                       };
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
        [HttpGet]
        public HttpResponseMessage FinanaceDashBoard()
        {
            project1Entities db = new project1Entities();
            var data1 = from fn1 in db.Finances
                        select new
                        {
                            Total_Credit = fn1.TotalAmount,
                            Credit_used = fn1.TotalAmount - fn1.RemainingAmount,
                            Remaining_Credit = fn1.RemainingAmount
                        };
            return Request.CreateResponse(HttpStatusCode.OK, data1);
        }
        [HttpGet]
        public HttpResponseMessage ProductDashBoard()
        {
            project1Entities db = new project1Entities();
            var data2 = from pr1 in db.Products
                        join fn1 in db.Finances on pr1.ProductID equals fn1.ProductID
                        select new
                        {
                            Product_Name = pr1.ProductName,
                            Amount = pr1.Price,
                            Paid = fn1.TotalAmount - fn1.RemainingAmount,
                            Balance = fn1.TotalAmount - fn1.RemainingAmount,
                            Product = pr1.ProductName,
                            Date = fn1.LastPaymentDate,
                            Amount_Paid = fn1.TotalAmount - fn1.RemainingAmount
                        };
            return Request.CreateResponse(HttpStatusCode.OK, data2);
        }
    }
}
