using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmEngine
{
    public interface IAlgorithmInput
    {
        /// <summary>
        /// Validates the AlgorithmInput parameters as per  algorithms logic
        /// </summary>
        bool ValidateInputParameters();
    }
}
