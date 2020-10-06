using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiInstanceWithAutofac.Services
{
    public class IncrementService : IIncrementService
    {
        /// <inheritdoc/>
        public int Increment(int count)
        {
            return count += 1;
        }
    }
}
