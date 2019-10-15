using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumericalMethods
{
	abstract class Method
	{
		public double[,] A { get; }
		public string Name { get; }

		internal double[] Mult(double[] v)
		{
			double[] result = new double[v.Length];

			for(int i = 0; i < A.GetLength(0); ++i) // rows
			{
				result[i] = 0.0;
				for(int j = 0; j < A.GetLength(1); ++j) // columns
				{
					result[i] += v[j] * A[i, j];
				}
			}

			return result;
		}

		abstract public double[] GetValue(double[] v, double step, double[,] A);
	}


	class Euler : Method
	{
		public override double[] GetValue(double[] v, double step, double[,] A)
		{
			// A * v
			double[] result = Mult(v);
			
			// v + step * result
			for(uint i = 0u; i < result.Length; ++i)
			{
				result[i] *= step;
				result[i] += v[i];
			}

			return result;
		}
	}


	class RK2 : Method
	{
		public override double[] GetValue(double[] v, double step, double[,] A)
		{
			// A * v
			double[] result = Mult(v);

			// v + result * (step / 2)
			for(uint i = 0u; i < result.Length; ++i)
			{
				result[i] *= step * 0.5;
				result[i] += v[i];
			}

			// A * result
			result = Mult(result);

			// v + result * step
			for(uint i = 0u; i < result.Length; ++i)
			{
				result[i] *= step;
				result[i] += v[i];
			}

			return result;
		}
	}


}
