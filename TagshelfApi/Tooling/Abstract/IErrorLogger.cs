using System;

namespace TagshelfApi.Tooling.Abstract
{
    public interface IErrorLogger
    {
        void LogError(Exception ex, string infoMessage);
    }
}
