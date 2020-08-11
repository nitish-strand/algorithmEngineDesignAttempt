using AlgorithmEngine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatasetCalculator
{
    public class Addition : IAlgorithmEngine
    {
        // dataset property
        public bool ValidateInputParameters()
        {
            // test if dataset.columnCount is more than zero
            return true;
        }

        public void Execute(IAlgorithm algorithm)
        {
            //Execute the given algorithm for the current dataset property
            if(ValidateInputParameters() == true)
            {
                algorithm.ExecuteAlgorithm();
            }
            else
            {
                Console.WriteLine();
            }
        }

        public IAlgorithmOutput ExecuteAlgorithm()
        {
            throw new NotImplementedException();
        }

        public void OutputFormat()
        {
            throw new NotImplementedException();
        }

        
        
    }
}
