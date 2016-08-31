/// MyRequireComponent.cs Agosto 22/2016 MoonPincho
/// 

using UnityEngine;

namespace MoonPincho
{
#if UNITY_5_4
    [RequireComponent(typeof(BoxCollider))]
    public class MyRequireComponent : MonoBehaviour
    {

    }
#endif
}
