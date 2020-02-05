using DotNetCoreVer1.Data;
using DotNetCoreVer1.Models;

namespace DotNetCoreVer1.InterFaces {
    public interface ISaveDB {
        void InjectData (TestingResult Data);
    }
    public class SaveDB : ISaveDB {
        private readonly TestResultContext _context;
        public SaveDB () {
        }
        public void InjectData (TestingResult Data) {

            _context.SaveChanges ();
        }
    }
}