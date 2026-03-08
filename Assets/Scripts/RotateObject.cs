using UnityEngine;


public class RotateObject : MonoBehaviour
{
    public float speed = 100f; //we need to set a speed var as the "Y" value of the transform.Rotate is multiplying the Input of the Axis of Input system, by our float for speed, and multiply in realtime

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal"); //

        transform.Rotate(Vector3.up * horizontal * speed * Time.deltaTime, Space.World);
    }
}
