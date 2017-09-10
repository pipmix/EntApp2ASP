using System;
using System.Collections;

namespace EntApp2.Models{


    public class Project{

        public int ID {get; set;}
        public string ProjectTitle {get; set;}
        public DateTime ProjectDate {get; set;}
        public string Description { get; set; }
        public string [] Languages {get;set;}
        public Language ProjectLanguages { get; set; }
        public string GithubURL { get; set; }
    }
/* 
    public List<String> Lang = new List<String>
    {
    "Ana",
    "Felipe",
    "Emillia"
    };
    */
    
}