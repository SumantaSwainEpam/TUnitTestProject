using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TunitTestProject.Data
{
    public class StringHelper
    {
        public async Task<string> ToUpperAsync(string value)
        {
            await Task.Delay(10);
            return value.ToUpper();
        }

        public async Task<bool> ContainsAsync(string input, string substring)
        {
            await Task.Delay(10);
            return input.Contains(substring);
        }

        public async Task<int> CountLengthAsync(string input)
        {
            await Task.Delay(10);
            return input.Length;
        }

    }
}
