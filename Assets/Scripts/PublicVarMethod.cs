using UnityEngine;

public class PublicVarMethod : MonoBehaviour
{
    //this script will contain the data we want to access
    public GameObject myTestObject;
    
    public string myName;

    public Color myColor;

    Renderer rend;

    void Start()
    {
       rend = myTestObject.GetComponent<Renderer>(); 
       //assigns the instance of the renderer component object we made in script memory to be the same renderer component on the object this script is attached to
    }

    public void myConsoleTest()
    {
        Debug.Log("My Name is " + myName);

    }

    public void myColorChange()
    {
        rend.material.color = myColor;
    }


    
}
