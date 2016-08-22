/// MyMenuItem.cs Agosto 22/2016 MoonPincho
/// 

using UnityEngine;
using UnityEditor;

namespace MoonPincho
{
    public class MyMenuItem : MonoBehaviour
    {
        [MenuItem("MoonPincho/My Custom SubMenu/My Custom Menu Item #%w")]
        private static void Init()
        {
            Debug.Log("Init was called");
        }

        [MenuItem("CONTEXT/Rigidbody/My Rigidbody Debug")]
        private static void RigidbodyDebug()
        {
            Debug.Log("RigidbodyDebug was called on: " + Selection.activeTransform.gameObject.name);
        }
    }
}
