#if !UNITY_EDITOR && UNITY_IOS
using System.Runtime.InteropServices;

namespace Haptic
{
    public static partial class HapticPlugin
    {
        private static bool? _isSupported;

        [DllImport("__Internal")]
        private static extern bool _Haptic_supported();

        [DllImport("__Internal")]
        private static extern void _Haptic_generate(int type);

        public static void Generate(FeedBackType type)
        {
            if(!_isSupported.HasValue) _isSupported = _Haptic_supported();

            if(!_isSupported.Value) return;

            _Haptic_generate((int) type);
        }
    }
}
#endif
