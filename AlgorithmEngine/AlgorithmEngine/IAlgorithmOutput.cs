using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmEngine
{
    public interface IAlgorithmOutput
    {
        bool ValidateOutput();

        void ReturnOutput();
    }
}
