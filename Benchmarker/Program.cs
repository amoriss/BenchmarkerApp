using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using System;
using System.Text;

namespace Benchmarker
{
    class Program
    {
        static void Main(string[] args)
        {
            var results = BenchmarkRunner.Run<Demo>();
        }
    }

    [MemoryDiagnoser]
    public class Demo
    {
        [Benchmark]
        public string GetFullStringNormally()
        {
            string output = "";
            for (int i = 0; i < 100; i++)
            {
                output += i;
            }

            return output;
        }

        [Benchmark]
        public string GetFullStringWithStringBuilder()
        {
            StringBuilder output = new StringBuilder();

            for (int i = 0; i < 100; i++)
            {
                output.Append(i);
            }

            return output.ToString();
        }
    }
}
