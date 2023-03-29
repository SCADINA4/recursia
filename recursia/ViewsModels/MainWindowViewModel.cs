using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using recursia.ViewsModels.Base;


namespace recursia.ViewsModels
{
    public class MainWindowViewModel:ViewModel
    {
        private long factorial;

        public long Factorial
        {
            get { return factorial; }
            set { Set(ref factorial, value); }
        }

        public long Qwe(long n)
        {
            if (n == 1) 
                return 1;

            return Factorial = n * Qwe(Convert.ToInt64((n - 1)));
        }
    }
}
