using System;
using DotNetCoreVer1.Data;
using DotNetCoreVer1.Models;



namespace DotNetCoreVer1.Services
{
    public interface ISaveDB
    {
        string InjectData (string TestResult);
    }
    public class SaveDB : ISaveDB {
        private readonly TestResultContext _context;
        public SaveDB(TestResultContext context)
        {
           _context = context;
        }
        
        public string InjectData (string TestResult) 
        {
            return "asdasd";
        }
    }
}