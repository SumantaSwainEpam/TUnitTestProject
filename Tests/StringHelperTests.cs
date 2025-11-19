using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TunitTestProject.Data;

namespace TUnitTestProject.Tests
{

    [ParallelGroup("Default")]
    public  class StringHelperTests
    {

        private StringHelper? _stringHelper;


        [Before(HookType.Test)]
        public void Setup()
        {
            // Arrange
            _stringHelper = new StringHelper();
        }

        [Test]
        public async Task ToUpperAsync_WithLowercaseString_ReturnsUppercase()
        {
            
            // Act
            var result = await _stringHelper.ToUpperAsync("hello");

            // Assert
            await Assert.That(result).IsEqualTo("HELLO");
        }

        [Test]
        public async Task ContainsAsync_WhenSubstringExists_ReturnsTrue()
        {
            

            var result = await _stringHelper.ContainsAsync("welcome home", "home");

            await Assert.That(result).IsTrue();
        }

        [Test]
        public async Task CountLengthAsync_WithValidString_ReturnsCorrectLength()
        {
            

            var result = await _stringHelper.CountLengthAsync("ChatGPT");

            await Assert.That(result).IsEqualTo(7);
        }

    }
}
