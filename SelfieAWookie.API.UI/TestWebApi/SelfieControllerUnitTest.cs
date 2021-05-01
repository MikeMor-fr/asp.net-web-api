using System;
using Microsoft.AspNetCore.Mvc;
using SelfieAWookie.API.UI.Controllers;
using Xunit;

namespace TestWebApi
{
    public class SelfieControllerUnitTest
    {
        [Fact]
        public void ShouldReturnListOfSelfies()
        {
            // ARRANGE
            var controller = new SelfiesController(null);

            // ACT
            var result = controller.Get();

            // ASSERT
            Assert.NotNull(result);
            Assert.IsType<OkObjectResult>(result);

            OkObjectResult okResult = result as OkObjectResult;
            Assert.NotNull(okResult.Value);
        }
    }
}