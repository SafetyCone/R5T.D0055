using System;
using System.Threading.Tasks;


namespace R5T.D0055
{
    /// <summary>
    /// Provides a stringly-typed directory path to which emails can be saved as files.
    /// </summary>
    public interface IEmailOutputDirectoryPathProvider
    {
        Task<string> GetEmailOutputDirectoryPath();
    }
}
