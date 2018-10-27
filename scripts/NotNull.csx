// [module:NoneNullType]


using System;
using System.Runtime.CompilerServices;

[module: NonNullTypes]

namespace A {
    public class P {
        public int A { set; get; }
    }

    public class C {
        public void M(P p) {
            var a = p.A;
        }
    }
}