/// MyRuntimeInitializeOnLoadMethod.cs Agosto 22/2016 MoonPincho
/// 

using UnityEngine;

namespace MoonPincho
{
#if UNITY_5_4
    public class MyRuntimeInitializeOnLoadMethod
    {
        [RuntimeInitializeOnLoadMethod]
        static void RunMeAtLoadTime()
        {
            Debug.Log("RunMeAtLoadTime - [MyRuntimeInitializeOnLoadMethod]");
        }

        void Start()
        {
            Debug.Log("Start - [MyRuntimeInitializeOnLoadMethod]");
        }

        void Update()
        {
            Debug.Log("Update - [MyRuntimeInitializeOnLoadMethod]");
        }
    }
#endif
}
