using UnityEngine;

public class BoolToggle : MonoBehaviour
{
    
    public bool toggleBool;
    public Color toggledColor;
    private Color originalColor;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        originalColor = this.GetComponent<Renderer>().material.color;
    }

    // Update is called once per frame
    void Update()
    {
        if(toggleBool)
        {this.GetComponent<Renderer>().material.color = toggledColor;
        }

        else
        {if(!toggleBool)
        {this.GetComponent<Renderer>().material.color = originalColor;
        }
        }
    }

    private void OnMouseDown() {
        toggleBool = !toggleBool;
    }
}
