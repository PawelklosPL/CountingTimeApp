using NUnit.Framework;
using CountingTimeApp;
using System;
using System.Collections.Generic;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void SingletonBehavior()
        {
            MyProces currentProcesInput = new MyProces();
            currentProcesInput.Name = "Name";
            currentProcesInput.Path = "C://file";
            currentProcesInput.MainWindowTitle = "MainWindowTitle";
            currentProcesInput.TimeIsCounted = false;
            currentProcesInput.StartTime = DateTime.Now;
            currentProcesInput.Time = TimeSpan.MaxValue;

            ProcessList processList = ProcessList.Instance;
            processList.processes = new List<MyProces>();
            processList.processes.Add(currentProcesInput);

            ProcessList processList2 = ProcessList.Instance;
            Assert.AreEqual(processList.processes.Count, 1);
            Assert.AreEqual(processList2.processes.Count, processList.processes.Count);

            Assert.AreEqual(processList2.processes[0].Name, processList.processes[0].Name);
            Assert.AreEqual(processList2.processes[0].Path, processList.processes[0].Path);
            Assert.AreEqual(processList2.processes[0].TimeIsCounted, processList.processes[0].TimeIsCounted);
            Assert.AreEqual(processList2.processes[0].MainWindowTitle, processList.processes[0].MainWindowTitle);
            Assert.AreEqual(processList2.processes[0].StartTime, processList.processes[0].StartTime);
            Assert.AreEqual(processList2.processes[0].Time, processList.processes[0].Time);
        }
    }
}