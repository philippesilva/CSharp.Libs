namespace CSharp.Libs.Results
{
    public struct ValidationError(string identifier, string errorMessage)
    {
        public string Identifier { get; set; } = identifier;
        public string ErrorMessage { get; set; } = errorMessage;
    }
}
