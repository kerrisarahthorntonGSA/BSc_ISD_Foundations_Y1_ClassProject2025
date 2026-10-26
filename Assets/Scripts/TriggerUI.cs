using UnityEngine;
using TMPro;

public class TriggerUI : MonoBehaviour
{

    public TextMeshProUGUI label;
    public GameObject myUI; 

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void OnTriggerEnter(Collider other) 
    {
        myUI.SetActive(true);
        
    }

     void OnTriggerExit(Collider other) 
    {
        myUI.SetActive(false);
        
    }
        
        
   
}

