namespace Sovran.Logger
{
    /// <summary>
    /// Main contract/interface for Sovran Logger.
    /// </summary>
    public interface ISovranLogger
    {
        void LogPayload(object payload);
        void LogActivity(string message);
        void LogError(string message);
    }
}