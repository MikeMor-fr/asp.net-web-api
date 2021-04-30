using System;
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
            var controller = new SelfiesController();
            
            // ACT
            var result = controller.Get();

            // ASSERT
            Assert.NotNull(result);
            Assert.True(result.GetEnumerator().MoveNext());
        }
    }
}