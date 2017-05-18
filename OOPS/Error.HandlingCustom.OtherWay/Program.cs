using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Error.HandlingCustom.OtherWay
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Sum().Data);
            Console.WriteLine(Message().Data);
            BaseResponse baseResponse = Divide();
            if (baseResponse.Status == true)
            {
                if (baseResponse is DerivedResponse)
                {
                    DerivedResponse result = (DerivedResponse)baseResponse;
                }
            }
            Console.Read();
        }

        static BaseGenericModelResponse<int> Sum()
        {
            var result = new BaseGenericModelResponse<int>();
            result.Data = 10;
            result.Status = true;
            return result;
        }

        static BaseGenericModelResponse<string> Message()
        {
            var result = new BaseGenericModelResponse<string>();
            result.Status = true;
            result.Data = "Message";
            return result;
        }

        static BaseResponse Divide()
        {
            var result = new DerivedResponse();
            result.Stack = "Hi";
            return result;
        }
    }

    public class BaseGenericModelResponse<T> //where T:class
    {
        public bool Status { get; set; }
        public string Message { get; set; }
        public T Data { get; set; }
        public ErrorAt ErrorAt { get; set; }
    }

    public class BaseResponse
    {
        public bool Status { get; set; }
        public string Message { get; set; }
        public ErrorAt ErrorAt { get; set; }
    }

    public class DerivedResponse : BaseResponse
    {
        public string Stack { get; set; }
    }

    public enum ErrorAt
    {
        Level1 = 1,
        Level2 = 2
    }
}
