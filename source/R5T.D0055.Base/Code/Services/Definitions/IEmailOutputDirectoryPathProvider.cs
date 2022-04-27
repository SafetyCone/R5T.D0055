using System;
using System.Threading.Tasks;

using R5T.T0064;


namespace R5T.D0055
{
    /// <summary>
    /// Provides a stringly-typed directory path to which emails can be saved as files.
    /// </summary>
    [ServiceDefinitionMarker]
    public interface IEmailOutputDirectoryPathProvider : IServiceDefinition
    {
        Task<string> GetEmailOutputDirectoryPath();
    }
}
