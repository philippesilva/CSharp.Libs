using System.Collections.Generic;

namespace CSharp.Libs.Results
{
    public interface IResult
    {
        IEnumerable<string> Errors { get; }
        List<ValidationError> ValidationErrors { get; }
        bool IsSuccess { get; }
    }
}
