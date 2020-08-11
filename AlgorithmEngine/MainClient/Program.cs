using AlgorithmEngine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainClient
{
    class Program
    {
        static void Main(string[] args)
        {
            AlgorithmEngine.AlgorithmEngine algorithm = new AlgorithmEngine.AlgorithmEngine();
            IAlgorithm  std= new StdDeviation.StandardDeviation();

            algorithm.Execute(std);
            
            Console.ReadLine();
        }
    }
}
