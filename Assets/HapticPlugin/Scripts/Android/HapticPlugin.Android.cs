#if !UNITY_EDITOR && UNITY_ANDROID
namespace Haptic
{
    public static partial class HapticPlugin
    {
        public static void Generate(FeedBackType type)
        {}
    }
}
#endif