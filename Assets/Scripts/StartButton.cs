using UnityEngine;
using System.Collections;

namespace Valve.VR.InteractionSystem
{
    public class StartButton : MonoBehaviour
    {
        public HoverButton hoverButton;
        public GameObject TrolleyObject;
        private TrolleyController trolleycontroller;

        private void Start()
        {
            hoverButton.onButtonDown.AddListener(OnButtonDown);
            trolleycontroller = TrolleyObject.GetComponent<TrolleyController>();
        }

        private void OnButtonDown(Hand hand)
        {
            trolleycontroller.go = true;
        }
    }
}