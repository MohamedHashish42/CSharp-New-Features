using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp9NewFeatures.Record
{
    #region Immutable properties

    #region 1- Using positional parameters
    public record Record1(string Property1, string Property2);
    #endregion

    #region 2- Using standard property syntax
    public record Record2
    {
        public string Property1 { get; init; }
        public string Property2 { get; init; }
    };
    #endregion

    #endregion

    #region Mutable properties
    public record Record3
    {
        public string Property1 { get; set; }
        public string Property2 { get; set; }
    };
    #endregion
}
