/// MyExecuteInEditMode.cs Agosto 22/2016 MoonPincho
/// 

using UnityEngine;

namespace MoonPincho
{
#if UNITY_5_4
    [ExecuteInEditMode]
    public class MyExecuteInEditMode : MonoBehaviour
    {
        private void Update()
        {
            gameObject.GetComponent<Renderer>().sharedMaterial.color = new Color(Random.Range(0f, 1f),
                                                                                 Random.Range(0f, 1f),
                                                                                 Random.Range(0f, 1f),
                                                                                 Random.Range(0f, 1f));
        }
    }
#endif
}
