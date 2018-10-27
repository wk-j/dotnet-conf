using System;
using Xunit;

// [module:NoneNullType]

namespace Ref {
    class P {

    }
    static class Demo {
        static ref readonly int RefDemo(this in int x, ref int y) {
            return ref x;
        }
        static void Go() {
            var a = 100;
            var b = 200;
            var c = a.RefDemo(ref b);
        }
    }
    public class UnitTest1 {
        [Fact]
        public void Test1() {
            void A(P p) {}

        }

        [Fact]
        public void Span() {
            var a = new int[10];
            for (int i = 0; i < 10; i++) {
                a[i] = i;
            }

            var span = a.AsSpan();
            var slice = span.Slice(0, 3);
            slice[0] = 100;

            foreach (var item in slice) {
                Console.WriteLine(item);
            }

            Assert.Equal(100, a[0]);

        }
    }
}
