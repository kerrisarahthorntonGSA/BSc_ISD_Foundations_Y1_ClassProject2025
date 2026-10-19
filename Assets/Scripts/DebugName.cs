using UnityEngine;

public class DebugName : MonoBehaviour
{
   public void OnMouseDown()
    {
        Debug.Log("The NAME of this object is " + name);
    }
}
 