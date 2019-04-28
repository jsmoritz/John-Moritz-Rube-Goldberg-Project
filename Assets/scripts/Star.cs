using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Star : MonoBehaviour {

    public GameManager GameManager;
    public VariableManager VariableManager;
    public SoundManager soundManager;

    void OnTriggerStay(Collider col)
    {
        if (col.CompareTag("Throwable"))
        {
            Rigidbody rigidBody = col.GetComponent<Rigidbody>();
            if (!rigidBody.isKinematic)
            {
                soundManager.source.clip = soundManager.stars;
                soundManager.source.Play();
                gameObject.SetActive(false);
                VariableManager.starsCollected++;
                //puzzle.CollectStar();
            }
        }
    }

}
