using System;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TopCoder.SRMs;

namespace TopCoder.SRMs.Test
{
    [TestClass]
    public class NamingConventionsTest
    {
        private NamingConvention namingConventionsClass = new NamingConvention();
      
        [TestMethod]
        public void NoChangeToVariableWhenSingleWord()
        {
            var singleWordVariableName = "test";

            var returnedVariableName = namingConventionsClass.toCamelCase(singleWordVariableName);

            Assert.AreEqual(returnedVariableName, singleWordVariableName);

            Debug.WriteLine(singleWordVariableName);

        }

        [TestMethod]
        public void ReturnEmptyStringWhenStringIsEmptyOrNull()
        {
            var blankVariableName = "";
            string nullVariableName = null;

            var returnedVariableNameEmpty = namingConventionsClass.toCamelCase(blankVariableName);
            var returnedVariableNameNull = namingConventionsClass.toCamelCase(nullVariableName);

            Assert.AreEqual(returnedVariableNameEmpty, blankVariableName);
            Assert.AreEqual(returnedVariableNameNull,"");

            Debug.WriteLine(returnedVariableNameEmpty);
        }


        [TestMethod]
        public void ReturnCamelCaseVariableTwoWords()
        {
            var twoWordVariableName = "snake_case";

            var returnedVariableTwoWords = namingConventionsClass.toCamelCase(twoWordVariableName);

            Assert.AreEqual(returnedVariableTwoWords, "snakeCase");

            Debug.WriteLine(returnedVariableTwoWords);
        }

        [TestMethod]
        public void ReturnCamelCaseVariableManyWords()
        {
            var manyWordVariableName = "this_is_a_long_variable_name";

            var returnedVariableManyWords = namingConventionsClass.toCamelCase(manyWordVariableName);

            Assert.AreEqual(returnedVariableManyWords, "thisIsALongVariableName");

            Debug.WriteLine(returnedVariableManyWords);

        }

    }
}
