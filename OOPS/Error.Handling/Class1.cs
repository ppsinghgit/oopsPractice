using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Error.Handling
{
     public class GetHealthInnerException : Exception
    {
        private string _msg;

        public GetHealthInnerException()
        {

        }

        public GetHealthInnerException(string message)
        {
            this._msg = message;

        }

        public GetHealthInnerException(string message, ErrorAt errorAt)
        {
            this._msg = message;
            this._errorAt = errorAt;
            this._status = true;
        }

        public GetHealthInnerException(object model, ErrorAt errorAt)
        {
            this.Model = model;
            this._errorAt = errorAt;
            this._status = true;
        }

        public GetHealthInnerException(string message, object model, ErrorAt errorAt)
        {
            this._msg = message;
            this.Model = model;
            this._errorAt = errorAt;
            this._status = true;
        }

        private bool _status;

        private ErrorAt _errorAt;

        public ErrorAt ErrorAt { get { return _errorAt; } }

        public override string Message
        {
            get
            {
                return _msg;
            }
        }

        public bool Status { get { return _status; } }

        public string ErrorMessage
        {
            get
            {
                return _msg;
            }
        }

        public object Model { get; set; }
    }

    public enum ErrorAt
    {
        MarketPlaceNullResponse = 1,
        MarketPlaceUnHandledResponse = 2,
        MarketPlaceDeserialization = 3,
        MarketPlaceInsertUpdate = 4,
        EligibilityNullOrUnExpectedResponse=5,
        EligibilityDeserialization=6,
        EligibilityInsertOrUpdate=7
    }

     public class LogExceptionModel
    {
        public string ClassName { get; set; }
        public string MethodName { get; set; }
        public string Parameters { get; set; }
        public string ExceptionMessage { get; set; }
        public string CustomErrorCode { get; set; }
    }
}
