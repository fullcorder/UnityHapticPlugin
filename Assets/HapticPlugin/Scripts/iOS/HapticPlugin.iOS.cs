﻿#if !UNITY_EDITOR && UNITY_IOS
using System.Runtime.InteropServices;

namespace Haptic
{
    public static class HapticPlugin
    {
        private static bool? _isSupported;

        [DllImport("__Internal")]
        private static extern bool _Haptic_supported();

        [DllImport("__Internal")]
        private static extern void _Haptic_generate(int type);

        public static void Generate(FeedBackType type)
        {
            if(!_isSupported.HasValue) _isSupported = IsSupported();

            if(!_isSupported.Value) return;

            _Haptic_generate((int) type);
        }

        public static bool IsSupported()
        {
            return _Haptic_supported();
        }
    }
}
#endif
