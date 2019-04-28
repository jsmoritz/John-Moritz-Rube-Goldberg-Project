using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class portal : MonoBehaviour {

    public float vel;

    void OnCollisionEnter(Collision col)
    { //Debug.Log(transform.position); 
        if (col.gameObject.CompareTag("Throwable"))
        {
            Debug.Log("hit portalA");
            GameObject ball = col.gameObject;
            GameObject portal2 = GameObject.Find("p2");
            Vector3 portal2Pos = portal2.transform.position;
            Debug.Log("Portal2 position =" + portal2.transform.position);
            //ball.transform.position = new Vector3(portal2Pos.x, portal2Pos.y, portal2Pos.z);
            ball.transform.position = portal2.transform.position; //+ portal2.transform.forward;
            Debug.Log("ball new position =" + ball.transform.position);
            Rigidbody rb = ball.GetComponent<Rigidbody>();
            Debug.Log("velocity" + rb.velocity);
            //rb.velocity = new Vector3(rb.velocity.x * -2, rb.velocity.y * -2, rb.velocity.z * -2);
            rb.velocity = portal2.transform.forward * vel;
            Debug.Log("new velocity" + rb.velocity);
        }
    }


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
