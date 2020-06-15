using System;

namespace PlumTest.Shared.Extensions
{
    public interface IErrorHandler
    {
        void HandleError(Exception ex);
    }
}
