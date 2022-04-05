using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Variables:
    public float speed = 5.0f;
    // The 'f' letter is added at the end to tell the script that this is a float number.
    // public: access modifier. By giving the variable a 'public' access modifier, it will now appear in the GameObject Inspector.
    public float turnSpeed;
    public float horizontalInput;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        // This variable receives the Horizontal axis from the Input Manager (Player Controls / Arrow Keys)

        // MOVE VEHICLE FORWARD (LOGIC):

        // transform.Translate(0, 0, 1); // <--- This was commented out because there's a cleaner way to implement this.

        // transform: calls the 'Transform' component of the GameObject.
        // Translate: translate = translation - This method allows to move the GameObject in the specified axis coordinates.

        transform.Translate(Vector3.forward * Time.deltaTime * speed);

        // Vector3.forward: shorthand for writing Vector3(0, 0, 1)
        // Vector3 refers to a structure that can receive 3D positions and directions, also includes functions for vector operations.

        // Time.deltaTime: deltaTime is the completion time in seconds since the last frame. In this case, it allows movement to become frame-independent.
        // Result: the movement speed will be equal to the 'speed' variable value.

        // TURN VEHICLE RIGHT (LOGIC):
        transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * horizontalInput);


    }
}
