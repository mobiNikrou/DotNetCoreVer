using DotNetCoreVer1.Models;
using DotNetCoreVer1.Data;

namespace DotNetCoreVer1.InterFaces 
{
    public interface IHandelInputData 
    {
        void LocalRoute (Test formval);
    }
    public class HandelInputData : IHandelInputData 
    {
        TestResultContext context;
        TestingResult Data;
        public HandelInputData () 
        {
            Data = new TestingResult();
            context = new TestResultContext();

        }
        public void LocalRoute (Test formval) 
        {
            switch (formval.ApplicatioName) 
            {
                case ApplicatioNames.AlborzContactManagingDirector:
                {
                    Data.TestCheck1 = "1";
                    Data.TestCheck2 = "2";
                    Data.TestCheck3 = "4";
                    context.TestingResult.Add(Data);
                    context.SaveChanges();
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
