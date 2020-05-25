using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using HW25_20_05_2020.Models;
using Dapper;
using System.Data.SqlClient;
using System.Data;

namespace HW25_20_05_2020.Controllers
{
    public class HomeController : Controller
    {
        private string conString = "Data Source=MACHINE-PGO7H84;Initial Catalog=MobileStoreDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public IActionResult Index()
        {
            using (IDbConnection db = new SqlConnection(conString))
            {

                var personList = db.Query<Person>($"SELECT * FROM PERSON").ToList();
                return View(personList);
            }
            
        }

       
    }
}
