using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Goal : MonoBehaviour {

    public GameManager GameManager;
    public SoundManager soundManager;
    public VariableManager VariableManager;
    public GameObject GO;
    public Image black;
    public Animator anim;

    


    void OnTriggerStay(Collider col)
    {
        if (col.CompareTag("Throwable"))
        {
            GameObject player = GameObject.Find("Player");
            GameObject ball = GameObject.Find("ball");
            Transform playerTransform = player.transform;
            Vector3 playerpos = playerTransform.position;
            float ypos = playerpos.y;
            Debug.Log("Player Y =" + ypos + "starsCollected = " + VariableManager.starsCollected);
            Rigidbody rigidBody = col.GetComponent<Rigidbody>();
            if (!rigidBody.isKinematic)
            {
                //gameObject.SetActive(false);
                if (VariableManager.starsCollected == VariableManager.starsNeeded && ypos > 0.7f)
                {
                    //GO.SetActive(true);

                    soundManager.source.clip = soundManager.gameover;
                    soundManager.source.Play();
                    

                    var clones = GameObject.FindGameObjectsWithTag("clone");
                    foreach (var clone in clones)
                    {
                        Destroy(clone);
                    }
                    Destroy(ball);
                    Destroy(player);
                    //StartCoroutine(Fading());
                    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
                }
                else
                {
                    GameManager.ResetStars();
                    soundManager.source.clip = soundManager.reset;
                    soundManager.source.Play();
                }
                
                //VariableManager.starsCollected++;
                //puzzle.CollectStar();
            }
        }
    }
    //IEnumerator Fading()
    //{
        //anim.SetBool("Fade", true);
        //yield return new WaitUntil(() => black.color.a == 1);
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    //}

}
