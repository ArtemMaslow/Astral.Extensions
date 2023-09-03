using Astral.Extensions.EnumHelper.Tests.TestEnums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Astral.Extensions.EnumHelper.Tests
{
    public class EnumHelperTests
    {

        [TestCase(ApplicationInfoV1.Anonymous)]
        [TestCase(ApplicationInfoV2.WebRegOfficeCertService)]
        [TestCase(ApplicationInfoV3.ActivationService)]
        public void GetAllApplicationNames_Correct<T>(T instance)
        {            
            var names = EnumHelper.GetAllApplicationNames<T>();
            var applicationNameCount = typeof(T).GetEnumValues().Length;
            Assert.That(names.Length, Is.EqualTo(applicationNameCount));
        }        
    }
}
