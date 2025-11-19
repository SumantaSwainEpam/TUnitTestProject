using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TunitTestProject.Data
{
    public class MyCalculator
    {

        /// <summary>
        /// Adds two numbers of various numeric types.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public Task<int> Add(int a, int b) => Task.FromResult(a + b);
        public Task<double> Add(double a, double b) => Task.FromResult(a + b);
        public Task<decimal> Add(decimal a, decimal b) => Task.FromResult(a + b);

        // Mixed-type addition (int + double, double + int)
        public Task<double> Add(int a, double b) => Task.FromResult(a + b);
        public Task<double> Add(double a, int b) => Task.FromResult(a + b);

        // Mixed-type addition (int + decimal, decimal + int)
        public Task<decimal> Add(int a, decimal b) => Task.FromResult(a + b);
        public Task<decimal> Add(decimal a, int b) => Task.FromResult(a + b);

        // Mixed-type addition (double + decimal → convert double to decimal)
        public Task<decimal> Add(double a, decimal b) => Task.FromResult((decimal)a + b);
        public Task<decimal> Add(decimal a, double b) => Task.FromResult(a + (decimal)b);



        /// <summary>
        /// Subtracts two numbers of various numeric types.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public Task<int> Sub(int a, int b) => Task.FromResult(a - b);
        public Task<double> Sub(double a, double b) => Task.FromResult(a - b);
        public Task<decimal> Sub(decimal a, decimal b) => Task.FromResult(a - b);

        public Task<double> Sub(int a, double b) => Task.FromResult(a - b);
        public Task<double> Sub(double a, int b) => Task.FromResult(a - b);

        public Task<decimal> Sub(int a, decimal b) => Task.FromResult(a - b);
        public Task<decimal> Sub(decimal a, int b) => Task.FromResult(a - b);

        public Task<decimal> Sub(double a, decimal b) => Task.FromResult((decimal)a - b);
        public Task<decimal> Sub(decimal a, double b) => Task.FromResult(a - (decimal)b);


        /// <summary>
        /// Multiplies two numbers of various numeric types.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public Task<int> Mul(int a, int b) => Task.FromResult(a * b);
        public Task<double> Mul(double a, double b) => Task.FromResult(a * b);
        public Task<decimal> Mul(decimal a, decimal b) => Task.FromResult(a * b);

        public Task<double> Mul(int a, double b) => Task.FromResult(a * b);
        public Task<double> Mul(double a, int b) => Task.FromResult(a * b);

        public Task<decimal> Mul(int a, decimal b) => Task.FromResult(a * b);
        public Task<decimal> Mul(decimal a, int b) => Task.FromResult(a * b);

        public Task<decimal> Mul(double a, decimal b) => Task.FromResult((decimal)a * b);
        public Task<decimal> Mul(decimal a, double b) => Task.FromResult(a * (decimal)b);


        /// <summary>
        /// Divides two numbers of various numeric types.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        /// <exception cref="DivideByZeroException"></exception>
        public Task<int> Div(int a, int b)
        {
            if (b == 0)
                throw new DivideByZeroException("Cannot divide by zero.");

            return Task.FromResult(a / b);
        }

        public Task<double> Div(double a, double b)
        {
            if (b == 0)
                throw new DivideByZeroException("Cannot divide by zero.");

            return Task.FromResult(a / b);
        }

        public Task<decimal> Div(decimal a, decimal b)
        {
            if (b == 0)
                throw new DivideByZeroException("Cannot divide by zero.");

            return Task.FromResult(a / b);
        }

        public Task<double> Div(int a, double b)
        {
            if (b == 0)
                throw new DivideByZeroException("Cannot divide by zero.");

            return Task.FromResult(a / b);
        }

        public Task<double> Div(double a, int b)
        {
            if (b == 0)
                throw new DivideByZeroException("Cannot divide by zero.");

            return Task.FromResult(a / b);
        }

        public Task<decimal> Div(int a, decimal b)
        {
            if (b == 0)
                throw new DivideByZeroException("Cannot divide by zero.");

            return Task.FromResult(a / b);
        }

        public Task<decimal> Div(decimal a, int b)
        {
            if (b == 0)
                throw new DivideByZeroException("Cannot divide by zero.");

            return Task.FromResult(a / b);
        }

        public Task<decimal> Div(double a, decimal b)
        {
            if (b == 0)
                throw new DivideByZeroException("Cannot divide by zero.");

            return Task.FromResult((decimal)a / b);
        }

        public Task<decimal> Div(decimal a, double b)
        {
            if (b == 0)
                throw new DivideByZeroException("Cannot divide by zero.");

            return Task.FromResult(a / (decimal)b);
        }

    }
}
