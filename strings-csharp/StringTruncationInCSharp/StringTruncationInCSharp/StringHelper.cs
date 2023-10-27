﻿using System.Text;
using System.Text.RegularExpressions;

namespace StringTruncationInCSharp
{
    public class StringHelper
    {
        public string TruncateStringUsingSubstring(string originalString, int maxLength)
        {
            var truncatedString = originalString.Substring(0, maxLength);

            return truncatedString;
        }
        
        public string TruncateStringUsingRemove(string originalString, int maxLength)
        {
            var truncatedString = originalString;

            if (originalString.Length > maxLength)
            {
                truncatedString = originalString.Remove(maxLength);
            }

            return truncatedString;
        }
        
        public string TruncateStringUsingStringBuilder(string originalString, int maxLength)
        {
            var truncatedStringBuilder = new StringBuilder(maxLength);

            for (int i = 0; i < Math.Min(maxLength, originalString.Length); i++)
            {
                truncatedStringBuilder.Append(originalString[i]);
            }

            var truncatedString = truncatedStringBuilder.ToString();

            return truncatedString;
        }
        
        public string TruncateStringUsingLINQ(string originalString, int maxLength)
        {
            var truncatedString = new string(originalString.Take(maxLength).ToArray());

            return truncatedString;
        }
        
        public string TruncateStringUsingForLoop(string originalString, int maxLength)
        {
            var truncatedString = string.Empty;
            int length = Math.Min(maxLength, originalString.Length);

            for (int i = 0; i < length; i++)
            {
                truncatedString += originalString[i];
            }

            return truncatedString;
        }
        
        public string TruncateStringUsingRegularExpressions(string originalString, int maxLength)
        {
            var truncatedString = Regex.Replace(originalString, $"^(.{{0,{maxLength}}}).*$", "$1");

            return truncatedString;
        }
    }
}