using AlgorithmEngine;
using System;
using System.Linq;
using OpenLab.Agilent.cube.dataset;

namespace StdDeviation
{
    public class StandardDeviation : IAlgorithm
    {
        private static float[] floatarr = new float[] { 23.5f, 10.34f, 56.8f, 44.7f, 60.1f };
        IColumn column = ColumnFactory.CreateFloatColumn("floatColumn", floatarr);

        public object ExecuteAlgorithm()
        {
            return ColumnOperations.StandardDeviation(column);
        }

        public bool ValidateInputParameters()
        {
            if (column.GetSize() > 0)
                return true;
            else
                return false;
        }

        public bool ValidateOutput()
        {
            if (ExecuteAlgorithm() != null)
            {
                return true;
            }
            else
                return false;
        }

        public void ReturnOutput()
        {
            if (ValidateOutput() is true)
            {
                Console.WriteLine("Output is ==> " + ExecuteAlgorithm());
            }
            else
                Console.WriteLine("Some error");
        }
    }
}
