using System;
using WP.Service.Localization;

namespace WP.Service.Helper
{
    public static class Verify
    {
        
        public static void NotEmpty(string value, string paramName)
        {
            if (value == null)
                _ThrowArgumentNullException(paramName);
            else if (value.Length == 0) 
                _ThrowEmptyStringException(paramName);

        }

        public static void NotNull(object o, string objName)
        {
            if (o == null)
                _ThrowArgumentNullException(objName);
        }

        private static void _ThrowArgumentNullException(string paramName)
        {
            var message = VerifyResources.NullArgument;
            throw new ArgumentNullException(paramName, message);
        }


        private static void _ThrowEmptyStringException(string paramName)
        {
            var message = VerifyResources.EmptyStringArgument;
            throw new ArgumentException(message, paramName);
        }
    }
}