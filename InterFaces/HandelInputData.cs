using DotNetCoreVer1.Models;

namespace DotNetCoreVer1.InterFaces 
{
    public interface IHandelInputData 
    {
        void LocalRoute (Test formval);
    }
    public class HandelInputData : IHandelInputData 
    {
        private readonly TestingResult testingresultdata;
        private readonly SaveDB savedb;
        public HandelInputData () 
        {
            savedb = new SaveDB();
            testingresultdata = new TestingResult();
        }
        public void LocalRoute (Test formval) 
        {
            switch (formval.ApplicatioName) 
            {
                case ApplicatioNames.AlborzContactManagingDirector:
                {
                   
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
    }
}
