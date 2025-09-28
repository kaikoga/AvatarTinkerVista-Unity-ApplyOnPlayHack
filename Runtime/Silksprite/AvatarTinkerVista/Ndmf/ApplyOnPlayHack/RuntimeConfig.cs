namespace Silksprite.AvatarTinkerVista.Ndmf.ApplyOnPlayHack
{
    public static class RuntimeConfig
    {
        /// <summary>
        /// Controls whether NDMF transformations will be applied at play time.
        /// </summary>
#if UNITY_EDITOR
        public static bool ApplyOnPlay => nadena.dev.ndmf.config.Config.ApplyOnPlay;
#else
        public static bool ApplyOnPlay => false;
#endif
    }
}
