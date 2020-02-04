using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Web;

namespace DotNetCoreVer1.Models
{
    public class Test
        
    {
        [Display(Name = "Project Name")]
        public ProjectNames ProjectName { get; set; }
        [Display(Name = "Application Name")]
        public ApplicatioNames ApplicatioName  { get; set; }
        [Display(Name = "Test Type")]
        public TestTypes TestType { get; set; }
    }
    public class TestingResult

    {
        public int Id { get; set; }
        [Display(Name = "TestCheck1")]
        public string TestCheck1 { get; set; }
        [Display(Name = "TestCheck2")]
        public string TestCheck2 { get; set; }
        [Display(Name = "TestCheck3")]
        public string TestCheck3 { get; set; }
    }
    public enum ProjectNames
    {
        lifeAlborzInsurance = 1,
        AlborzInsurance = 2
    }
    public enum ApplicatioNames
    {
        AlborzContactManagingDirector = 1,
    }
    public enum TestTypes
    {
        AcceptanceTest = 1,
        OwaspTest = 2,
    }

}