/// MyRuntimeInitializeOnLoadMethod.cs Agosto 22/2016 MoonPincho
/// 

using UnityEngine;
using UnityEditor;

namespace MoonPincho
{
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
}
