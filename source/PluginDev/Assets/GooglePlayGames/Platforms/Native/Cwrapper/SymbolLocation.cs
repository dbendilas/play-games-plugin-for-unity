using System;

namespace GooglePlayGames.Native.Cwrapper {
internal static class SymbolLocation {
    #if UNITY_ANDROID
    internal const string NativeSymbolLocation = "gpg";
    #endif
}
}

