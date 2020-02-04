using DotNetCoreVer1.Models;

namespace DotNetCoreVer1.InterFaces
{
    public interface IHandelInputData
    {
        void LocalRoute(Test applicationames, Test testtypes, Test projectnames);
    }
    public class HandelInputData : IHandelInputData
    {
        public HandelInputData()
        {
            
        }
        public void LocalRoute(Test applicationames, Test testtypes, Test projectnames)
        {

        }
    }

}