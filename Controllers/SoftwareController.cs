using System;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Mvc;

namespace EntApp2{

    public class SoftwareController : Controller {

        public IActionResult Index(){
            return View();
        }

        public IActionResult MoreData(){
            ViewData["Message"] = "fe eeeeeea ";
            
            return View();
        }

        [HttpGet("/")]
        public string MoreCont(){
            return "000";
        }




    }


}