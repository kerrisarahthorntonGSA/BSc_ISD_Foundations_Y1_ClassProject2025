using UnityEngine;

public class PublicVarMethod : MonoBehaviour
{
    //this script will contain the data we want to access

    
    public string myName;

    public void myConsoleTest()
    {
        Debug.Log("My Name is " + myName);

    }


    
}
