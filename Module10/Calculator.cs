using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Module10.Operations;

namespace Module10
{
    internal class Calculator : IAddition
    {
        // реализуйте его
        public int Addition(int a, int b)
        {
            try
            {
                checked
                {
                    return a + b;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
            finally
            {
                Console.WriteLine("Блок Finally сработал!");
            }
        }
    }
}
