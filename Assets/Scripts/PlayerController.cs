using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Move the vehicle forward:

        // transform.Translate(0, 0, 1); // <--- This was commented out because there's a cleaner way to implement this.

        // transform: calls the 'Transform' component of the GameObject.
        // Translate: translate = translation - This method allows to move the GameObject in the specified axis coordinates.

        transform.Translate(Vector3.forward); // Shorthand for writing Vector3(0, 0, 1)
        // Vector3 refers to a structure that can receive 3D positions and directions, also includes functions for vector operations.

    }
}
