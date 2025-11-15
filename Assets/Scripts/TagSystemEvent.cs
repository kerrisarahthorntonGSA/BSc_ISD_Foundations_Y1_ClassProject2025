using UnityEngine;

public class TagSystemEvent : MonoBehaviour
{
    
    void OnMouseEnter()
    {
        if (gameObject.tag == "myInteractable")
        {
           Debug.Log("Object is " + name); 
        }
        
    }
}
