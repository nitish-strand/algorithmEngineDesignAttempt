using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmEngine
{
    public class AlgorithmEngine : IAlgorithmEngine
    {
        public void Execute(IAlgorithm algorithm)
        {
            algorithm.ExecuteAlgorithm();
            algorithm.ReturnOutput();
        }
    }
}
