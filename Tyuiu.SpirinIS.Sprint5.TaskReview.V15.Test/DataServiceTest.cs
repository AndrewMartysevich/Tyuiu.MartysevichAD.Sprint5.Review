using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.SpirinIS.Sprint5.TaskReview.V15.Lib;

namespace Tyuiu.SpirinIS.Sprint5.TaskReview.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\ridui\source\repos\Tyuiu.MartysevichAD.Sprint5.Review\Tyuiu.SpirinIS.Sprint5.TaskReview.V15\bin\Debug\OutPutDataFileTask7V15.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
