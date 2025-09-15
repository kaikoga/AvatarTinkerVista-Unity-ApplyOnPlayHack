#nullable enable
using System.Collections.Generic;
using nadena.dev.ndmf.runtime;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Silksprite.AvatarTinkerVista.Ndmf.ApplyOnPlayHack
{
    /// <summary>
    /// A collection of general-purpose utilities that are available from Runtime-scope scripts.
    /// </summary>
    static class RuntimeUtilInternal
    {
        /// <summary>
        /// Returns the component marking the root of the avatar.
        /// </summary>
        /// <param name="scene"></param>
        /// <returns></returns>
        internal static IEnumerable<Transform> FindAvatarsInScene(Scene scene)
        {
            foreach (var root in scene.GetRootGameObjects())
            {
                foreach (var avatar in RuntimeUtil.FindAvatarRoots(root))
                {
                    yield return avatar.transform;
                }
            }
        }
        
        internal static T GetOrAddComponent<T>(this GameObject obj) where T : Component
        {
            if (!obj.TryGetComponent<T>(out var component)) component = obj.AddComponent<T>();
            return component;
        }
    }
}
