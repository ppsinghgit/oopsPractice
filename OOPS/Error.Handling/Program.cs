using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Error.Handling
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                new Program().A();
            }
            catch (GetHealthInnerException ex)
            {

            }
            catch (Exception ex)
            {
                if (ex is GetHealthInnerException)
                {
                    throw ex;
                }
                else
                {
                    throw new GetHealthInnerException(
                        new LogExceptionModel()
                        {
                            ClassName = "Main",
                            MethodName = "Main()",
                            Parameters = "params",
                            CustomErrorCode = "",
                            ExceptionMessage = ex.ToString()
                        },
                    ErrorAt.EligibilityDeserialization);
                }
            }
        }


        void A()
        {
            try
            {
                string name = GetCurrentMethod();
                B();
            }
            catch (Exception ex)
            {
                if (ex is GetHealthInnerException)
                {
                    throw ex;
                }
                else
                {
                    throw new GetHealthInnerException(
                        new LogExceptionModel()
                        {
                            ClassName = "Main",
                            MethodName = "A()",
                            Parameters = "params",
                            CustomErrorCode = "",
                            ExceptionMessage = ex.ToString()
                        },
                    ErrorAt.EligibilityDeserialization);
                }
            }
        }

        void B()
        {
            try
            {
                string name = GetCurrentMethod();
                C();
            }
            catch (Exception ex)
            {
                if (ex is GetHealthInnerException)
                {
                    throw ex;
                }
                else
                {
                    throw new Exception("InnerException", new GetHealthInnerException(
                        new LogExceptionModel()
                        {
                            ClassName = "Main",
                            MethodName = "B()",
                            Parameters = "params",
                            CustomErrorCode = "",
                            ExceptionMessage = ex.ToString()
                        },
                    ErrorAt.EligibilityDeserialization));
                }
            }
        }

        void C()
        {
            try
            {
                string name = GetCurrentMethod();
                D();
            }
            catch (Exception ex)
            {
                if (ex is GetHealthInnerException)
                {
                    throw ex;
                }
                else
                {
                    throw new GetHealthInnerException(
                        new LogExceptionModel()
                        {
                            ClassName = "Main",
                            MethodName = "C()",
                            Parameters = "params",
                            CustomErrorCode = "",
                            ExceptionMessage = ex.ToString()
                        },
                    ErrorAt.EligibilityDeserialization);
                }
            }
        }

        void D()
        {
            try
            {
                string name = GetCurrentMethod();
                int a = 0;
                int b = 10 / a;
                E();
            }
            catch (Exception ex)
            {
                if (ex is GetHealthInnerException)
                {
                    throw ex;
                }
                else
                {
                    throw new GetHealthInnerException(
                        new LogExceptionModel()
                        {
                            ClassName = this.GetType().Name,
                            MethodName = GetCurrentMethod(),
                            Parameters = "params",
                            CustomErrorCode = "",
                            ExceptionMessage = ex.ToString()
                        },
                    ErrorAt.EligibilityDeserialization);
                }
            }
        }

        void E()
        {
            try
            {
                throw new Exception("Manually Throw at E()");
            }
            catch (Exception ex)
            {
                if (ex is GetHealthInnerException)
                {
                    throw ex;
                }
                else
                {
                    throw new GetHealthInnerException(
                        new LogExceptionModel()
                        {
                            ClassName = "Main",
                            MethodName = "E()",
                            Parameters = "params",
                            CustomErrorCode = "",
                            ExceptionMessage = ex.ToString()
                        },
                    ErrorAt.EligibilityDeserialization);
                }
            }
        }

        [MethodImpl(MethodImplOptions.NoInlining)]
        public static string GetCurrentMethod()
        {
            StackTrace st = new StackTrace();
            StackFrame sf = st.GetFrame(1);
            return sf.GetMethod().Name;
        }
    }

    public class InsertException : Exception
    {
        private string msg;

        public InsertException(string Message)
        {
            msg = Message;
        }

        public override string ToString()
        {
            return msg;
        }

        public override string Message
        {
            get
            {
                return msg;
            }
        }
    }

    public class UpdateException : Exception
    {
        private string msg;

        public UpdateException(string Message)
        {
            msg = Message;
        }

        public override string ToString()
        {
            return msg;
        }

        public override string Message
        {
            get
            {
                return msg;
            }
        }
    }

    public class FFmException : Exception
    {
        private string msg;

        public FFmException(string Message)
        {
            msg = Message;
        }

        public override string ToString()
        {
            return msg;
        }

        public override string Message
        {
            get
            {
                return msg;
            }
        }
    }

}
