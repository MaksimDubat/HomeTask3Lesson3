
namespace homework12
{
    internal class WrongLoginException : Exception
    {
        private string exLogin {  get; set; }  = string.Empty;
        internal WrongLoginException() { }
        internal WrongLoginException(string exLogin, string message) : base(message) 
        {
            this.exLogin = exLogin;
        }


    }
}
