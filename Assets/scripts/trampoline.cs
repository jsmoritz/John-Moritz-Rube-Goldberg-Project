using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trampoline : MonoBehaviour {

    private bool bounce = false;
    public float bounceAmount;


    void OnCollisionEnter(Collision col)
    {
        Debug.Log("Collision working");
        if (col.gameObject.CompareTag("Throwable"))
        {
            Debug.Log("is ball");
            Rigidbody rb = col.gameObject.GetComponent<Rigidbody>();
            rb.AddForce(transform.up * 5f, ForceMode.Impulse);
        }
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
