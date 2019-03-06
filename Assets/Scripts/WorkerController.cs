using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorkerController : MonoBehaviour
{

    private Animator workerAnim;

	// Use this for initialization
	void Start ()
    {
        workerAnim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        //Debug.Log(other.gameObject.name);
        if (other.gameObject.CompareTag("Trolley"))
        {
            workerAnim.enabled = false;
        }
    }
}
