using System;
using DotNetCoreVer1.Data;
using DotNetCoreVer1.Models;



namespace DotNetCoreVer1.Services
{
    public interface ISaveDB
    {
        string InjectData ();
    }
    public class SaveDB : ISaveDB {
        private readonly TestResultContext _context;
        public SaveDB(TestResultContext context)
        {
           _context = context;
        }
        
        public string InjectData () 
        {
            TestingResult a = new TestingResult();
            a.TestCheck1 = "1";
            a.TestCheck2 = "2";
            a.TestCheck3 = "3";
            _context.Add(a);
            _context.SaveChanges();
            return "asdasd";
        }
    }
}