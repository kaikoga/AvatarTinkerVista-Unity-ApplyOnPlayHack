using Anatawa12.AvatarOptimizer.API;
using UnityEngine;

namespace Silksprite.AvatarTinkerVista.Ndmf.ApplyOnPlayHack.Aao
{
    [ComponentInformation(typeof(AvatarActivator))]
    class EntrypointComponentInformation : ComponentInformation<Component>
    {
        protected override void CollectDependency(Component component, ComponentDependencyCollector collector)
        {
            collector.MarkEntrypoint();
        }
    }
}
