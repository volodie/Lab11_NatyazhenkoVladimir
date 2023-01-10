using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generics
{
    class ComparablePair<T, U> : IComparable<ComparablePair<T, U>>
    {
        public T Obj1 { get; set; }
        public U Obj2 { get; set; }
        public ComparablePair(T _obj1, U _obj2)
        {
            Obj1 = _obj1;
            Obj2 = _obj2;
        }

        public override string ToString()
        {
            return $"({Obj1.ToString()}, {Obj2.ToString()})";
        }

        public void GetCompareResult(ComparablePair<T, U> pair, Action<string> output)
        {
            int i = CompareTo(pair);
            if (i == 0) { output($"{this.ToString()} == {pair.ToString()}"); }
            else if (i > 0) { output($"{this.ToString()} > {pair.ToString()}"); }
            else { output($"{this.ToString()} < {pair.ToString()}"); }
        }
        public int CompareTo(ComparablePair<T, U>? other)
        {
            if (Obj1.ToString() == other.Obj1.ToString())
                return string.Compare(Obj2.ToString(), other.Obj2.ToString());
            return string.Compare(Obj1.ToString(), other.Obj1.ToString());
        }

    }
}
