using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParametersAssignment
{
    class GenericEmployee
    {
        // Generic Employee class with type parameter T
        public class Employee<T>
        {
            // Public property 'Things' typed as a List of T
            public List<T> Things { get; set; }
        }
    }
}
