using DotNetCoreVer1.Models;

namespace DotNetCoreVer1.InterFaces
{
    public interface ISaveDB
    {
        void InjectData (TestingResult testingresultdata);
    }
    public class SaveDB : ISaveDB
    {
        public SaveDB () 
        {
            
        }
        public void InjectData (TestingResult testingresultdata) 
        {
        }
    }
}