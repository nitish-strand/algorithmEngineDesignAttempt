using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmEngine
{
    public interface IAlgorithmEngine
    {
        void Execute(IAlgorithm algorithm);
    }
}
