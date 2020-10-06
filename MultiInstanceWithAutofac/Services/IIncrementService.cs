using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiInstanceWithAutofac.Services
{
    public interface IIncrementService
    {
        /// <summary>
        /// Inrements the count.
        /// </summary>
        /// <param name="count">The count to increment.</param>
        /// <returns>The new count.</returns>
        int Increment(int count);
    }
}
