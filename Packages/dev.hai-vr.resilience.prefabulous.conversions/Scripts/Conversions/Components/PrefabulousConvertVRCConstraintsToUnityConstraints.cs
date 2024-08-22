using UnityEngine;
#if PREFABULOUS_CONVERSIONS_VRCHAT_IS_INSTALLED
using IPrefabulousEditorOnly = VRC.SDKBase.IEditorOnly;
#else
using Prefabulous.Universal.Shared.Runtime;
#endif

namespace Prefabulous.Conversions.Runtime
{
    [AddComponentMenu("Prefabulous/PA-Conversions VRC Constraints -> Unity Constraints")]
    public class PrefabulousConvertVRCConstraintsToUnityConstraints : MonoBehaviour, IPrefabulousEditorOnly
    {
    }
}