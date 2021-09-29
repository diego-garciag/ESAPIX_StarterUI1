using Microsoft.VisualStudio.TestTools.UnitTesting;
using ESAPX_StarterUI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ESAPIX.Constraints;

namespace ESAPX_StarterUI.ViewModels.Tests
{
    [TestClass()]
    public class CTDateConstraintTests
    {
        [TestMethod()]
        public void ConstrainTestPassed()
        {
            // Assert.Fail(); created by defaul, fails

            // Arrange
            var ctDate = DateTime.Now.AddDays(-59);

            // Act
            var actual = new CTDateConstraint().Constrain(ctDate).ResultType;

            // Assert
            var expected = ResultType.PASSED;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void ConstrainTestFails()
        {
            // Assert.Fail(); created by defaul, fails

            // Arrange
            var ctDate = DateTime.Now.AddDays(-61);

            // Act
            var actual = new CTDateConstraint().Constrain(ctDate).ResultType;

            // Assert
            var expected = ResultType.ACTION_LEVEL_3;
            Assert.AreEqual(expected, actual);
        }
    }
}