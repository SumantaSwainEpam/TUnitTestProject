using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TUnitTestProject.Data
{
     public class BooleanHelper
     {
        public async Task<bool> IsEvenAsync(int number)
        {
            await Task.Delay(10);
            return number % 2 == 0;
        }

        public async Task<bool> IsAdultAsync(int age)
        {
            await Task.Delay(10);
            return age >= 18;
        }

    }
}
