
namespace homework12
{
    internal class WrongPasswordException : Exception
    {
        private string exPassword {  get; set; } = string.Empty;
        internal WrongPasswordException () { }
        internal WrongPasswordException(string exPassword, string message) : base (message)
        {
            this.exPassword = exPassword;
        }
    }
}
