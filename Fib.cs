
//#r "System.Core.dll"
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

  public class Startup
    {       
        public async Task<object> Invoke(object input)
        {
            int v = (int)input;
            var fib = Fix<int, int>(f => x => x <= 1 ? 1 : f(x - 1) + f(x - 2));
            return fib(v);
        }
       
       

        static Func<T, TResult> Fix<T, TResult>(Func<Func<T, TResult>, Func<T, TResult>> f)
        {
            return x => f(Fix(f))(x);
        }

        static Func<T1, T2, TResult> Fix<T1, T2, TResult>(Func<Func<T1, T2, TResult>, Func<T1, T2, TResult>> f)
        {
            return (x, y) => f(Fix(f))(x, y);
        }
    }
