using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfType
{
    public class OfType<T>:IOfType
    {
        public IEnumerable<T> GetOfType<T>(IEnumerable enumerable)
        {
            return enumerable.OfType<T>();
        }

        public IEnumerable<TOutput> GetOfType<TSource, TOutput>(IEnumerable<TSource> enumerable)
        {
            return GetOfType<TOutput>(enumerable);
        }

        public IEnumerable<TBase> OfBase<TBase, TDerived>(IEnumerable<TDerived> derivedItems) where TDerived : TBase
        {
            return GetOfType<TDerived,TBase>(derivedItems);
        }
    }
}
