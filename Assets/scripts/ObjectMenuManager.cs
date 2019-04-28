using System.Collections.Generic;
using UnityEngine;



public class ObjectMenuManager : MonoBehaviour {

    public List<GameObject> objectList; //handled automatically at start
    public List<GameObject> objectPrefabList; //set manually in inspector and MUST match order of scene menu objects
    private GameObject clone;
    private GameObject menuClone;
    public VariableManager variableManager;

    public int currentObject = 0;

	// Use this for initialization
	void Start () {
		foreach(Transform child in transform)
        {
            objectList.Add(child.gameObject);
        }
            
    }
	public void MenuLeft()
    {
        objectList[currentObject].SetActive(false);
        objectList[5].SetActive(false);
        currentObject--;
        if (currentObject < 0)
        {
            currentObject = objectList.Count - 2;
        }
        
        bool myBool = IsAvail(currentObject);
        if (myBool == true)
        {
            objectList[currentObject].SetActive(true);
            objectList[5].SetActive(false);
        }
        else
        {
            objectList[5].SetActive(true);
            setPanels(objectList[5], currentObject);
            objectList[currentObject].SetActive(false);
        }
        
    }
	public void MenuRight()
    {
        objectList[currentObject].SetActive(false);
        objectList[5].SetActive(false);
        
        currentObject++;
        if (currentObject > objectList.Count - 2)
        {
            currentObject = 0;
        }
        Debug.Log("check1 co = " + currentObject);
        
        bool myBool = IsAvail(currentObject);
        if (myBool == true)
        {
            objectList[currentObject].SetActive(true);
            objectList[5].SetActive(false);
        }
        else
        {
            objectList[5].SetActive(true);
            setPanels(objectList[5], currentObject);
            objectList[currentObject].SetActive(false);
        }
    }
    public void MenuOn()
    {
        bool myBool = IsAvail(currentObject);
        
        if (myBool == true)
        {
            objectList[currentObject].SetActive(true);
            objectList[5].SetActive(false);
        }
        else
        {
            objectList[5].SetActive(true);
            setPanels(objectList[5], currentObject);
            objectList[currentObject].SetActive(false);
        }
    }
    public void MenuOff()
    {
        objectList[currentObject].SetActive(false);
        objectList[5].SetActive(false);
        
    }
    public void setPanels(GameObject theParent, int currentObject)
    {
        foreach (Transform child in theParent.transform)
        {
            child.gameObject.SetActive(false);
            switch (currentObject)
            {
                case 0:
                    if (child.gameObject.tag == "c0")
                    {
                        child.gameObject.SetActive(true);
                    }
                    break;
                case 1:
                    if (child.gameObject.tag == "c1")
                    {
                        child.gameObject.SetActive(true);
                    }
                    break;
                case 2:
                    if (child.gameObject.tag == "c2")
                    {
                        child.gameObject.SetActive(true);
                    }
                    break;
                case 3:
                    if (child.gameObject.tag == "c3")
                    {
                        child.gameObject.SetActive(true);
                    }
                    break;
                case 4:
                    if (child.gameObject.tag == "c4")
                    {
                        child.gameObject.SetActive(true);
                    }
                    break;
                default:
                    break;
            }

        }
    }
    public void SpawnCurrentObject()
    {
        //Debug.Log("Add Object " + currentObject + "," + objectPrefabList[currentObject] + "," + objectList[currentObject]);
                bool myBool;

        switch (currentObject)
        {
            
            case 0:
                
                myBool = IsAvail(0);
                if (myBool == true)
                {
                    clone = Instantiate(objectPrefabList[currentObject], objectList[currentObject].transform.position, objectList[currentObject].transform.rotation);
                    clone.tag = "clone";
                    variableManager.woodPlankUsed++;
                    myBool = IsAvail(0);
                    if (myBool == false)
                    {
                        objectList[0].SetActive(false);
                        objectList[5].SetActive(true);
                        setPanels(objectList[5], currentObject);
                    }
                }
                else
                {
                    objectList[0].SetActive(false);
                    objectList[5].SetActive(true);
                    setPanels(objectList[5], currentObject);

                }
                break;
            case 1:
                myBool = IsAvail(1);
                if (myBool == true)
                {
                    clone = Instantiate(objectPrefabList[currentObject], objectList[currentObject].transform.position, objectList[currentObject].transform.rotation);
                    clone.tag = "clone";
                    variableManager.metalPlankUsed++;
                    myBool = IsAvail(1);
                    if (myBool == false)
                    {
                        objectList[1].SetActive(false);
                        objectList[5].SetActive(true);
                        setPanels(objectList[5], currentObject);
                    }
                }
                else
                {
                    objectList[1].SetActive(false);
                    objectList[5].SetActive(true);
                    setPanels(objectList[5], currentObject);

                }
                break;
            case 2:
                myBool = IsAvail(2);
                if (myBool == true)
                {
                    clone = Instantiate(objectPrefabList[currentObject], objectList[currentObject].transform.position, objectList[currentObject].transform.rotation);
                    clone.tag = "clone";
                    variableManager.trampolineUsed++;
                    myBool = IsAvail(2);
                    if (myBool == false)
                    {
                        objectList[2].SetActive(false);
                        objectList[5].SetActive(true);
                        setPanels(objectList[5], currentObject);
                    }
                }
                else
                {
                    objectList[2].SetActive(false);
                    objectList[5].SetActive(true);
                    setPanels(objectList[5], currentObject);

                }
                break;
            case 3:
                myBool = IsAvail(3);
                if (myBool == true)
                {
                    clone = Instantiate(objectPrefabList[currentObject], objectList[currentObject].transform.position, objectList[currentObject].transform.rotation);
                    clone.name = "p1";
                    clone.tag = "clone";
                    variableManager.portal1Used++;
                    myBool = IsAvail(3);
                    if (myBool == false)
                    {
                        objectList[3].SetActive(false);
                        objectList[5].SetActive(true);
                        setPanels(objectList[5], currentObject);
                    }
                }
                else
                {
                    objectList[3].SetActive(false);
                    objectList[5].SetActive(true);
                    setPanels(objectList[5], currentObject);

                }
                break;
            case 4:
                myBool = IsAvail(4);
                if (myBool == true)
                {
                    clone = Instantiate(objectPrefabList[currentObject], objectList[currentObject].transform.position, objectList[currentObject].transform.rotation);
                    clone.name = "p2";
                    clone.tag = "clone";
                    variableManager.portal2Used++;
                    myBool = IsAvail(4);
                    if (myBool == false)
                    {
                        objectList[4].SetActive(false);
                        objectList[5].SetActive(true);
                        setPanels(objectList[5], currentObject);
                    }
                }
                else
                {
                    objectList[4].SetActive(false);
                    objectList[5].SetActive(true);
                    setPanels(objectList[5], currentObject);

                }
                break;
            default:
                variableManager.defaultVar++;
                
                break;
        }
        
    }
    
    public bool IsAvail (int obj)
    {
        switch (obj)
        {
            case 0:
                if (variableManager.woodPlankUsed < variableManager.woodPlankAvail)
                {
                    return true;
                }
                return false;
                
            case 1:
                if (variableManager.metalPlankUsed < variableManager.metalPlankAvail)
                {
                    return true;
                }
                return false;
                
            case 2:
                if (variableManager.trampolineUsed < variableManager.trampolineAvail)
                {
                    return true;
                }
                return false;

            case 3:
                if (variableManager.portal1Used < variableManager.portal1Avail)
                {
                    return true;
                }
                return false;

            case 4:
                if (variableManager.portal2Used < variableManager.portal2Avail)
                {
                    return true;
                }
                return false;
            default:
                return false;
        }
        
    }
}
