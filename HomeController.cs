using Microsoft.AspNetCore.Mvc;
using System;
using Microsoft.Extensions.Primitives;
using System;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;


namespace MyWebApplication.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : ControllerBase
    {
       [HttpPost]

       public void create([FromBody] Create_Webhook ActionPayload)
        {
            // return "Packialakshmi Subramanian";

        }

        /* public bool AddEmpDetails()
         {
             return true;
             //write insert logic  
         }*/
        [HttpGet]
        public string GetEmpDetails()
        {
            return "Packialakshmi Subramanian";

        }
        [HttpDelete]
        public string DeleteEmpDetails(string id)
        {
            return "Employee details deleted having Id " + id;

        }
        [HttpPut]
        public string UpdateEmpDetails(string Name, String Id)
        {
            return "Employee details Updated with Name " + Name + " and Id " + Id;

        }
        
    }           
    
}