using DotNetCoreVer1.Models;

namespace DotNetCoreVer1.InterFaces 
{
    public interface IHandelInputData 
    {
        void LocalRoute (Test EnumObj);
    }
    public class HandelInputData : IHandelInputData 
    {
        public HandelInputData () 
        {

        }
        public void LocalRoute (Test EnumObj) 
        {
            switch (EnumObj.ApplicatioName) 
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
