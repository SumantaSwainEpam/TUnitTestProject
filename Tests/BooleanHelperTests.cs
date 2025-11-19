using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TUnitTestProject.Data;

namespace TUnitTestProject.Tests
{   

    [ParallelGroup("Default")]
    public class BooleanHelperTests
    {

        private BooleanHelper? _booleanHelper;

        [Before(HookType.Test)]
        public void Setup()
        {
            // Arrange
            _booleanHelper = new BooleanHelper();
        }


        [Test]
        public async Task IsEvenAsync_WithEvenNumber_ReturnsTrue()
        {

            // Act
            var result = await _booleanHelper.IsEvenAsync(10);

            // Assert
            await Assert.That(result).IsTrue();
        }

        [Test]
        public async Task IsEvenAsync_WithOddNumber_ReturnsFalse()
        {
            

            var result = await _booleanHelper.IsEvenAsync(7);

            await Assert.That(result).IsFalse();
        }

        [Test]
        public async Task IsAdultAsync_WithAge18OrAbove_ReturnsTrue()
        {
            
            var result = await _booleanHelper.IsAdultAsync(20);

            await Assert.That(result).IsTrue();

        }

        [Test]
        public async Task IsAdultAsync_WithAgeBelow18_ReturnsFalse()
        {
            

            var result = await _booleanHelper.IsAdultAsync(15);

            await Assert.That(result).IsFalse();
        }

    }
}
