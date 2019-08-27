using System;


namespace R5T.Code.VisualStudio.Extensions
{
    public static class BooleanExtensions
    {
        public static string ToStringVsFileFormat(this bool value)
        {
            var output = value.ToString().ToLowerInvariant();
            return output;
        }
    }
}
