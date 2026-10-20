using UnityEngine;

public class RBNav : MonoBehaviour
{
    //This script will allow for movement that uses the Physics System in Unity (It will stop object passing through walls etc)
    [SerializeField]
    private float speed = 10f;

    Rigidbody _rb;
    Vector2 _movement;

    
    void Start()
    {
        _rb = GetComponent<Rigidbody>();//this initializes the _rb variable we created on line 9 to be the SPECIFIC Rigidbody component of the GameObject that this script is attached to
    }

    
    void Update()
    {
        _movement = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));//this allows us to store the current input of the NEW Input System in real time as our _movement variable
        
    }

    private void FixedUpdate()//FixedUpdate() is a method in Monobehavior that runs like Update but is better for physics-based interactions
    {
        MovePositionRB(_movement);//Here we are calling the CUSTOM method we created on line 35 called MovePosition(), and we are passing in the variable _movement as the data we want used.
    }

    void AddForce()//Here we have a method to use the AddForce function of the Rigidbody component and we are using the Input of the WASD keys to execute. We have not called this method so it is currently unused.
    {
        _rb.AddForce(_movement);
    }

    void MovePositionRB(Vector2 _direction)//This is a custom method we created and we have created a NEW Vector2 as an argument to pass in this meeting
    {
        _rb.MovePosition(_rb.position + new Vector3(_direction.x, 0, _direction.y) * speed * Time.fixedDeltaTime);//_rb.MovePosition is a function of the RigidBody component that takes arguments to action. It is taking the position of the Rigidbody (a Vector3), and it is adding a NEW Vector3, multiplies this by the speed variable we created on line 7, and multiplies this by Time.fixedDeltaTime - which is the time interval in seconds that the physics and fixed-rate updates (FixedUpdate) are performed. Because we are using FixedUpdate, we need to use this Time.
    }

}