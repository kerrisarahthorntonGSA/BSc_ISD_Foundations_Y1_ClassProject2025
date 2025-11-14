using UnityEngine;

public class AccessScriptTest : MonoBehaviour
{
    /* This Script will access our PublicVarMethods script to get the daat/method we want

    To do this, we need to do some things. If you recall in our Animator Script, we needed
    to store the type of Animator as a variable in the script? 
    And we made a reference to the class Animator and gave it a name to create a variable of that type.

    In this script we need to do the same. We need to make a reference to the class ( which IS the script) and give it a name to create a variable of that type.

    This will create an instance of that type and assign it to the variable name we give it.

    But then we need to assign that variable to be the specific script because we want to get those changes in realtime.
    In some other cases it might be fine to just make an instance of the script in your script ( for examople, maybe you want to have all your characters have the same magic spells, and you might have a mage script that you could just make an instance of because you just want to access the libraires and methods of that script)
    But in this exercise, we want to change the date like the colour and our Name in real-time on an Game Object, so we need to access that specific script.
    
    So we will also need to have a public GameObject Field, to attach the game object that our date script is attached to.

    Then we need to assign this in our start method.

    Then we can access the methods and variables from that script in our object.
    
    */


    public GameObject myDataObject;//this is the game object our data script will be attached to

    PublicVarMethod myPVMScript;//this is how you create an instsnce of a class in your script

    void Start()
    {
        myPVMScript = myDataObject.GetComponent<PublicVarMethod>();//this assigns the specific script/class component that is on our GameObject
    }


    void Update()
    {
        myPVMScript.myConsoleTest();//this will run the method from our other script and Print a line in the console
        
    }
}
