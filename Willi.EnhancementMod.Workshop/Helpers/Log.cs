using UnityEngine;

namespace Willi.EnhancementMod.Workshop.Helpers
{
    public static class Log
    {
        private const string LogIdentifier = "[Willi.EnhancementMod]: ";

        public static void Info(string message)
        {
            Debug.Log(LogIdentifier + message);
        }

        public static void Warning(string message)
        {
            Debug.LogWarning(LogIdentifier + message);
        }

        public static void Error(string message)
        {
            Debug.LogError(LogIdentifier + message);
        }
    }
}
