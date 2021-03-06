﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AutomationFramework.Base;
using AutomationFramework.Config;
using TechTalk.SpecFlow;

namespace AutomationTestProject
{
    [Binding]
    public sealed class Hooks1 : TestInitializeHook
    {
        //public Hooks1(): base(BrowserType.Chrome) { }
        private ParallelConfig _parallelConfig;
        public Hooks1(ParallelConfig parallelConfig) : base(parallelConfig)
        {
            _parallelConfig = parallelConfig;
        }

        [BeforeScenario]
        public void BeforeScenario()
        {
           
            InitializeSettings();
            NavigateToSite(Settings.AUT); //should we be calling settings here???
        }

        [AfterScenario]
        public void AfterScenario()
        {
            //DriverContext.Driver.Quit();
            _parallelConfig.Driver.Quit();
        }


        
    }
}
