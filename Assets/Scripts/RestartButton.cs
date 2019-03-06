using UnityEngine;
using System.Collections;

namespace Valve.VR.InteractionSystem
{
    public class RestartButton : MonoBehaviour
    {
        public HoverButton hoverButton;
        public GameObject TrolleyObject;
        private TrolleyController trolleycontroller;
        public GameObject[] workers;
        private Animator workerAnim;

        private void Start()
        {
            hoverButton.onButtonDown.AddListener(OnButtonDown);
            trolleycontroller = TrolleyObject.GetComponent<TrolleyController>();
            workers = GameObject.FindGameObjectsWithTag("Worker");
        }

        private void OnButtonDown(Hand hand)
        {
            trolleycontroller.go = false;
            trolleycontroller.transform.position = new Vector3(-18.594f, 1.05f, 9.935f);
            trolleycontroller.num01 = 0;
            trolleycontroller.num02 = 0;
            trolleycontroller.switcher = false;
            trolleycontroller.disable_switch = false;
            trolleycontroller.checker = false;

            for(int i = 0; workers.Length > i; i++)
            {
                workerAnim = workers[i].GetComponent<Animator>();
                workerAnim.enabled = true;
            }
        }
    }
}