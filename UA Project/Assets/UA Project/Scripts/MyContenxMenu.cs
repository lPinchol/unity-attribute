/// MyContenxMenu.cs Agosto 22/2016 MoonPincho
/// 

using UnityEngine;

namespace MoonPincho
{
    public class MyContenxMenu : MonoBehaviour
    {
        [ContextMenuItem("Add","AddMethod")]
        [ContextMenuItem("Subtract", "RemoveMethod")]
        [ContextMenuItem("Reset", "ResetMethod")]
        public int lives = 10;

        [ContextMenu("Add A Life")]
        private void AddMethod()
        {
            Debug.Log("Add Option of the Context Menu");
            lives++;
        }

        [ContextMenu("Remove A Life")]
        private void RemoveMethod()
        {
            Debug.Log("Remove Option of the Context Menu");
            lives--;
        }

        [ContextMenu("Reset Life")]
        private void ResetMethod()
        {
            Debug.Log("Reset Option of the Context Menu");
            lives = 10;
        }
    }
}
