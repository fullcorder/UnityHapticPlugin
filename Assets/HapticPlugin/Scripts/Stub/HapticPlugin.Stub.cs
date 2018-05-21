#if UNITY_EDITOR
namespace Haptic
{
    public static class HapticPlugin
    {
        public static void Generate(FeedBackType type)
        {
        }

        public static bool IsSupported()
        {
            return false;
        }
    }
}
#endif