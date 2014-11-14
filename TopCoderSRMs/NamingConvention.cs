using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TopCoder.SRMs
{
   public class NamingConvention
    {
        public string toCamelCase(string snakeCaseVariable)
        {

            if (string.IsNullOrEmpty(snakeCaseVariable))
                return "";
            if (!snakeCaseVariable.Contains("_"))
                return snakeCaseVariable;

            StringBuilder camelCaseVariableToReturn = new StringBuilder();

            string[] snakeCaseVariableToArray = snakeCaseVariable.Split('_');

            camelCaseVariableToReturn.Append(snakeCaseVariableToArray[0]);

            for (int i = 1; i < snakeCaseVariableToArray.Length; i++)
            {
                var currentWord = snakeCaseVariableToArray[i];

                camelCaseVariableToReturn.Append(currentWord[0].ToString().ToUpper());
                camelCaseVariableToReturn.Append(currentWord.Substring(1, currentWord.Length - 1));
            }

            return camelCaseVariableToReturn.ToString();
        }

    }
}
