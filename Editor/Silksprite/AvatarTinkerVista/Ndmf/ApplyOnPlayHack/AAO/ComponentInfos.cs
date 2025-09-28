using Anatawa12.AvatarOptimizer.API;
using UnityEngine;

namespace Silksprite.AvatarTinkerVista.Ndmf.ApplyOnPlayHack.Aao
{
    [ComponentInformation(typeof(Silksprite.AvatarTinkerVista.Ndmf.ApplyOnPlayHack.AvatarActivator))]
    class EntrypointComponentInformation : ComponentInformation<Component>
    {
        protected override void CollectDependency(Component component, ComponentDependencyCollector collector)
        {
            collector.MarkEntrypoint();
        }
    }
}
