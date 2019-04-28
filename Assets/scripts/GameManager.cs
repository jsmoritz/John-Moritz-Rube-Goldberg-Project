using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public VariableManager variableManager;
    public List<Star> stars;

    void ResetField()
    {

    }
    // Use this for initialization
    void Start () {
		
	}
    
    // Update is called once per frame
    void Update () {
		
	}

    public void ResetStars()
    {
        foreach (Star star in stars)
        {
            star.gameObject.SetActive(true);
            variableManager.starsCollected = 0;
        }
    }
}
