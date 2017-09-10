using System;
using Microsoft.AspNetCore.Mvc;
//using System.Text.Encodings.Web

namespace EntApp2{

    public class ProjectsController : Controller
    {
            public string Index()
            {
                return "This Index";
            }
            // Get moredat
            public string MoreData()
            {
                return "This More Data";
            }


    }


}