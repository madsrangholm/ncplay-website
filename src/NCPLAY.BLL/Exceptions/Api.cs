using System;
using NCPLAY.BLL.Datatypes;

namespace NCPLAY.BLL.Exceptions
{
    public class ApiException : Exception
    {
        public ApiException(string message) : base(message)
        {
        }

        public ApiException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

        public ApiException(string message, Exception innerException, ApiErrorResponse errResponse)
            : base(message, innerException)
        {
            ErrResponse = errResponse;
        }

        public ApiException(string message, ApiErrorResponse errResponse) : base(message)
        {
            ErrResponse = errResponse;
        }

        public ApiException(ApiErrorResponse errResponse)
        {
            ErrResponse = errResponse;
        }

        public ApiErrorResponse ErrResponse { get; private set; }

        public override string ToString()
        {
            return ErrResponse != null
                ? ErrResponse.ToString()
                : base.ToString();
        }
    }
}