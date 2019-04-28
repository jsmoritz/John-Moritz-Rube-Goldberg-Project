using UnityEngine;
using Valve.VR;
using Valve.VR.InteractionSystem;

public class HandInteraction : MonoBehaviour {

    //[SteamVR_DefaultAction("SelectObject", "default")]
    public SteamVR_Action_Vector2 cycleObjects;
    //[SteamVR_DefaultAction("AddObject", "default")]
    public SteamVR_Action_Boolean addObj;
    public Hand hand;

    public float sensitivity = 0.5f;
    //swipe
    
    public bool hasSwipedLeft;
    public bool hasSwipedRight;
    public bool hasSwipedUp;
    public bool hasSwipedDown;

    public ObjectMenuManager ObjectMenuManager;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        var leftHoriz = cycleObjects.GetAxis(SteamVR_Input_Sources.LeftHand);
        var rightHoriz = cycleObjects.GetAxis(SteamVR_Input_Sources.LeftHand);

        var UpVert = cycleObjects.GetAxis(SteamVR_Input_Sources.LeftHand);
        var DownVert = cycleObjects.GetAxis(SteamVR_Input_Sources.LeftHand);
        

        if (!hasSwipedLeft)
        {
            if (leftHoriz.x < -0.5f)
            {
                swipeLeft();
                hasSwipedLeft = true;
                hasSwipedRight = false;
            }
        }

        if (!hasSwipedRight)
        {
            if (rightHoriz.x > 0.5f)
            {
                swipeRight();
                hasSwipedRight = true;
                hasSwipedLeft = false;
            }
        }
        if (!hasSwipedUp)
        {
            if (UpVert.y > 0.5f)
            {
                swipeUp();
                hasSwipedUp = true;
                hasSwipedDown = false;

            }
        }
        if (!hasSwipedDown)
        {
            if (DownVert.y < -0.5f)
            {
                swipeDown();
                hasSwipedDown = true;
                hasSwipedUp = false;
            }
        }
        if (leftHoriz.x > -0.5f & rightHoriz.x < 0.5f)
        {
            hasSwipedLeft = false;
            hasSwipedRight = false;
            leftHoriz.x = 0;
            rightHoriz.x = 0;
        }
        if (UpVert.y < 0.5f & DownVert.y > -0.5f)
        {
            hasSwipedUp = false;
            hasSwipedDown = false;
            UpVert.y = 0;
            DownVert.y = 0;
        }
        if (addObj.GetStateDown(SteamVR_Input_Sources.Any))
        {
            SpawnObject();
        }     
    }
    void SpawnObject()
    {
        Debug.Log("Add Object");
        ObjectMenuManager.SpawnCurrentObject();
    }
    void swipeLeft()
    {
        ObjectMenuManager.MenuLeft();
        Debug.Log("SwipeLeft");
    }
    void swipeRight()
    {
        ObjectMenuManager.MenuRight();
        Debug.Log("SwipeRight");
    }
    void swipeUp()
    {
        ObjectMenuManager.MenuOn();
        Debug.Log("Turn menu on.");
    }
    void swipeDown()
    {
        ObjectMenuManager.MenuOff();
        Debug.Log("Turn menu off.");
    }
}
