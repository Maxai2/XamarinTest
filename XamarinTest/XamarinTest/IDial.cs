using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace XamarinTest
{
    public interface IDial
    {
        Task<bool> DialAsync(string number);
    }
}
