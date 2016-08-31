/// MyInitializeOnLoad.cs Agosto 22/2016 MoonPincho
/// 

using UnityEngine;
using UnityEditor;

namespace MoonPincho
{
#if UNITY_5_4
    [InitializeOnLoad]
    public class MyInitializeOnLoad
    {

        static MyInitializeOnLoad()
        {
            Debug.Log("MyInitializeOnLoad - Winning!");
        }

        private void Start()
        {
            Debug.Log("MyInitializeOnLoad - Start!");
        }

        private void Awake()
        {
            Debug.Log("MyInitializeOnLoad - Awake!");
        }

        private void Update()
        {
            Debug.Log("MyInitializeOnLoad - Update!");
        }
    }
#endif
}
