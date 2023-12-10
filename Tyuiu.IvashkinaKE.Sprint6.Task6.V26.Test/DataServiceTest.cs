using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using System.IO;

using Tyuiu.IvashkinaKE.Sprint6.Task6.V26.Lib;

namespace Tyuiu.IvashkinaKE.Sprint6.Task6.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            
            DataService ds = new DataService();
            string wait = "HlidZPHKeLLU OoyPFhjSRwp GUilXww iukCfO UaZNpcgYjw";
            string path = @"C:\DataSprint6\InPutFileTask6V26.txt";
            string res = ds.CollectTextFromFile(path);
           
            Assert.AreEqual(wait, res);
        }

        public void CheckedExistsFile()
        {
            string path = @"C:\DataSprint6\InPutFileTask6V26.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            Assert.AreEqual(true, fileExists);
        }
    }
}