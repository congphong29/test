using System;
using System.Collections.Generic;
using DemoApp.Controllers;
using Microsoft.AspNetCore.Mvc;
using Xunit;

namespace DemoApp.Tests
{
    public class ValuesControllerTest
    {
        private readonly ValuesController controller;

        public ValuesControllerTest(){
            this.controller = new ValuesController();
        }

        [Fact]
        public void GetAlls()
        {
            //run
            var result = controller.Get();   
            
            //assert
            Assert.IsAssignableFrom<IEnumerable<string>>(result.Value);
        }

        [Fact]
        public void GetById()
        {
            //run
            var result = controller.Get(1);   
            
            //assert
            Assert.IsAssignableFrom<string>(result.Value);
            Assert.Equal("value", result.Value);
        }
    }
}
