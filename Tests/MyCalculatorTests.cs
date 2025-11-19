using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TunitTestProject.Data;
using TUnit;
using System.Reflection;

namespace TunitTestProject.Tests
{
    [ParallelGroup("Default")]
    public class MyCalculatorTests
    {
        private MyCalculator? _calculator;

        [Before(HookType.Test)]
        public void Setup()
        {
            _calculator = new MyCalculator();
        }


        [Test]
        public async Task Add_Int_Int()
        {
            var result = await _calculator.Add(5, 10);
            await Assert.That(result).IsEqualTo(15);
        }

        [Test]
        public async Task Add_Double_Double()
        {
            var result = await _calculator.Add(2.5, 3.5);
            await Assert.That(result).IsEqualTo(6.0);
        }

        [Test]
        public async Task Add_Decimal_Decimal()
        {
            var result = await _calculator.Add(2.5m, 3.5m);
            await Assert.That(result).IsEqualTo(6.0m);
        }

        [Test]
        public async Task Add_Int_Double()
        {
            var result = await _calculator  .Add(2, 3.5);
            await Assert.That(result).IsEqualTo(5.5);
        }

        [Test]
        public async Task Add_Double_Int()
        {
            var result = await _calculator.Add(3.5, 2);
            await Assert.That(result).IsEqualTo(5.5);
        }

        [Test]
        public async Task Add_Int_Decimal()
        {
            var result = await _calculator.Add(4, 2.5m);
            await Assert.That(result).IsEqualTo(6.5m);
        }

        [Test]
        public async Task Add_Decimal_Int()
        {
            var result = await _calculator.Add(2.5m, 4);
            await Assert.That(result).IsEqualTo(6.5m);
        }

        [Test]
        public async Task Add_Double_Decimal()
        {
            var result = await _calculator.Add(2.5, 3.5m);
            await Assert.That(result).IsEqualTo(6.0m);
        }

        [Test]
        public async Task Add_Decimal_Double()
        {
            var result = await _calculator.Add(3.5m, 2.5);
            await Assert.That(result).IsEqualTo(6.0m);
        }



        // SUBTRACT

        [Test]
        public async Task Sub_Int_Int()
        {
            var result = await _calculator.Sub(5, 3);
            await Assert.That(result).IsEqualTo(2);
        }

        [Test]
        public async Task Sub_Double_Double()
        {
            var result = await _calculator.Sub(5.5, 3.5);
            await Assert.That(result).IsEqualTo(2.0);
        }

        [Test]
        public async Task Sub_Decimal_Decimal()
        {
            var result = await _calculator.Sub(5.5m, 3.5m);
            await Assert.That(result).IsEqualTo(2.0m);
        }

        [Test]
        public async Task Sub_Int_Double()
        {
            var result = await _calculator.Sub(5, 2.5);
            await Assert.That(result).IsEqualTo(2.5);
        }

        [Test]
        public async Task Sub_Double_Int()
        {
            var result = await _calculator.Sub(5.5, 2);
            await Assert.That(result).IsEqualTo(3.5);
        }

        [Test]
        public async Task Sub_Int_Decimal()
        {
            var result = await _calculator.Sub(6, 2.5m);
            await Assert.That(result).IsEqualTo(3.5m);
        }

        [Test]
        public async Task Sub_Decimal_Int()
        {
            var result = await _calculator.Sub(5.5m, 2);
            await Assert.That(result).IsEqualTo(3.5m);
        }

        [Test]
        public async Task Sub_Double_Decimal()
        {
            var result = await _calculator.Sub(6.5, 2.5m);
            await Assert.That(result).IsEqualTo(4.0m);
        }

        [Test]
        public async Task Sub_Decimal_Double()
        {
            var result = await _calculator.Sub(6.5m, 2.5);
            await Assert.That(result).IsEqualTo(4.0m);
        }



        // MULTIPLY


        [Test]
        public async Task Mul_Int_Int()
        {
            var result = await _calculator.Mul(3, 4);
            await Assert.That(result).IsEqualTo(12);
        }

        [Test]
        public async Task Mul_Double_Double()
        {
            var result = await _calculator.Mul(2.5, 4.0);
            await Assert.That(result).IsEqualTo(10.0);
        }

        [Test]
        public async Task Mul_Decimal_Decimal()
        {
            var result = await _calculator.Mul(2.5m, 4m);
            await Assert.That(result).IsEqualTo(10m);
        }

        [Test]
        public async Task Mul_Int_Double()
        {
            var result = await _calculator.Mul(3, 2.5);
            await Assert.That(result).IsEqualTo(7.5);
        }

        [Test]
        public async Task Mul_Double_Int()
        {
            var result = await _calculator.Mul(2.5, 3);
            await Assert.That(result).IsEqualTo(7.5);
        }

        [Test]
        public async Task Mul_Int_Decimal()
        {
            var result = await _calculator.Mul(3, 2.5m);
            await Assert.That(result).IsEqualTo(7.5m);
        }

        [Test]
        public async Task Mul_Decimal_Int()
        {
            var result = await _calculator.Mul(2.5m, 3);
            await Assert.That(result).IsEqualTo(7.5m);
        }

        [Test]
        public async Task Mul_Double_Decimal()
        {
            var result = await _calculator.Mul(2.5, 4m);
            await Assert.That(result).IsEqualTo(10m);
        }

        [Test]
        public async Task Mul_Decimal_Double()
        {
            var result = await _calculator.Mul(2.5m, 4.0);
            await Assert.That(result).IsEqualTo(10m);
        }



        // DIVIDE


        [Test]
        public async Task Div_Int_Int()
        {
            var result = await _calculator.Div(10, 2);
            await Assert.That(result).IsEqualTo(5);
        }

        [Test]
        public async Task Div_Double_Double()
        {
            var result = await _calculator.Div(7.5, 2.5);
            await Assert.That(result).IsEqualTo(3.0);
        }

        [Test]
        public async Task Div_Decimal_Decimal()
        {
            var result = await _calculator.Div(7.5m, 2.5m);
            await Assert.That(result).IsEqualTo(3.0m);
        }

        [Test]
        public async Task Div_Int_Double()
        {
            var result = await _calculator.Div(5, 2.5);
            await Assert.That(result).IsEqualTo(2.0);
        }

        [Test]
        public async Task Div_Double_Int()
        {
            var result = await _calculator.Div(7.5, 3);
            await Assert.That(result).IsEqualTo(2.5);
        }

        [Test]
        public async Task Div_Int_Decimal()
        {
            var result = await _calculator.Div(10, 4m);
            await Assert.That(result).IsEqualTo(2.5m);
        }

        [Test]
        public async Task Div_Decimal_Int()
        {
            var result = await _calculator.Div(10m, 4);
            await Assert.That(result).IsEqualTo(2.5m);
        }

        [Test]
        public async Task Div_Double_Decimal()
        {
            var result = await _calculator.Div(7.5, 2.5m);
            await Assert.That(result).IsEqualTo(3.0m);
        }

        [Test]
        public async Task Div_Decimal_Double()
        {
            var result = await _calculator.Div(7.5m, 2.5);
            await Assert.That(result).IsEqualTo(3.0m);
        }

        
        // DIVIDE BY ZERO
     

        [Test]
        public async Task Div_ByZero_Throws()
        {
            var act = () => _calculator.Div(10, 0);

            await Assert.That(act).Throws<DivideByZeroException>();
        }




    }
}
