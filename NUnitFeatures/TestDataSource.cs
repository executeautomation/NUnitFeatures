using NUnit.Framework;
using System.Collections;

namespace NUnitFeatures
{
    public class TestDataSource
    {

        public static IEnumerable Datas
        {
            get
            {
                yield return new TestCaseData(60, 70).Returns(130);
                yield return new TestCaseData(20, 30).Returns(50);
            }
        }

    }
}
