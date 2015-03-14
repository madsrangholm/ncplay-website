using System.Diagnostics.Contracts;

namespace NCPLAY.BLL.Datatypes
{
    public abstract class ApiErrorResponse
    {
        public new abstract string ToString();
    }

    public class EmptyErrorResponse : ApiErrorResponse
    {
        public override string ToString()
        {
            Contract.Ensures(Contract.Result<string>() == null);
            return null;
        }
    }
}