using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetBall : MonoBehaviour {

    public GameManager gameManager;
    public VariableManager variableManager;
    public SoundManager SoundManager;
    public Rigidbody rigidBody;
    public Transform ballStart;


    // Use this for initialization
    void Start () {
		
	}
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag("Floor"))
        {
            transform.position = ballStart.position;
            transform.rotation = Quaternion.identity;
            rigidBody.velocity = Vector3.zero;
            rigidBody.angularVelocity = Vector3.zero;
            SoundManager.source.clip = SoundManager.reset;
            SoundManager.source.Play();
            gameManager.ResetStars();
        }
    }
    // Update is called once per frame
    void Update () {
		
	}
}
