using System.ComponentModel;

namespace CSharp.Libs.Tests.Enums
{
    public enum Status
    {
        [Description("Success")]
        Success,

        [Description("Information")]
        Information,

        [Description("Error")]
        Error,

        [Description("Warning")]
        Warning,
    }
}
