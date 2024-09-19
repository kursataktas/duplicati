namespace Duplicati.WebserverCore.Abstractions;

/// <summary>
/// The registration of a remote control for this machine
/// </summary>
public interface IRemoteControllerRegistration
{
    /// <summary>
    /// Begin the registration of a machine
    /// </summary>
    /// <param name="registrationUrl">The URL to register the machine with</param>
    /// <returns>The claim URL</returns>
    Task<string> RegisterMachine(string registrationUrl);

    /// <summary>
    /// Waits for the registration to complete.
    /// </summary>
    /// <returns>The task to wait on</returns>
    public Task WaitForRegistration();

    /// <summary>
    /// Cancels the registration of the machine
    /// </summary>
    void CancelRegisterMachine();

    /// <summary>
    /// Attempts to end the registration of a machine
    /// </summary>
    /// <returns>If the registration was successful</returns>
    Task<bool> EndRegisterMachine();

    /// <summary>
    /// A flag indicating if the machine is currently registering
    /// </summary>
    bool IsRegistering { get; }
    /// <summary>
    /// The URL to register the machine with, if registring
    /// </summary>
    string? RegistrationUrl { get; }
}
