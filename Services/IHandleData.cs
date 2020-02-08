using DotNetCoreVer1.Models;
using DotNetCoreVer1.Data;
using DotNetCoreVer1.Infrastructure;

namespace DotNetCoreVer1.Services 
{
    public interface IHandleData
    {
        void LocalRoute (Test formval);
    }
    public class HandleData : IHandleData
    {
        
        private readonly ISaveDB _savedb;
        public HandleData (ISaveDB savedb)
        {
            _savedb =  savedb;
        }
        public void LocalRoute (Test formval) 
        {
            switch (formval.ApplicatioName) 
            {
                case ApplicatioNames.AlborzContactManagingDirector:
                {
                    
                    string TestResult = "Calling test script here";
                     
                    _savedb.InjectData(TestResult);
                    
                    // context.TestingResult.Add(Data);
                    // context.SaveChanges();
                    // switch (applicationames) {
                    //     case ApplicatioNames.AlborzContactManagingDirector:
                    //         {
                    //             switch (testtypes) {
                    //                 case TestTypes.AcceptanceTest:
                    //                     // string[] testrepo = Testobj.TestAction1();

                    //                     // IList<TestingResult> TestResultList = new List<TestingResult>();
                    //                     // TestResultList.Add(new TestingResult() { TestCheck1 = ApplicatioName,TestCheck2 = ProjectName, TestCheck3 = TestType });

                    //                     //  TestingResult aaa = new TestingResult();
                    //                     //  aaa.TestCheck1 = ApplicatioName;
                    //                     //  aaa.TestCheck2 = ProjectName;
                    //                     //  aaa.TestCheck3 = TestType;

                    //                     //  ViewData["testindexlist"] = TestResultList;
                    //                     break;
                    //             }
                    //         }
                    //         break;
                    // }
                    break;
                }
            }
        }
        public string HelloWorld()
        {
             return "HelloWorld";
        }
    }
}
