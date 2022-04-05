using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    // Variables:
    public GameObject player;
    // The 'Vehicle' GameObject will become the Reference for this 'player' variable in the Inspector (drag and drop in Unity)
    private Vector3 offset = new Vector3(0, 5, -7);
    // This variable will be used in the Update method in order to reposition the Main Camera behind the 'Vehicle' GameObject


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is replaced by 'LateUpdate' which is called after the Update method,
    // this solves a jitter issue where the object being followed by the camera is not smoothly synchronized
    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
        // Takes the current Position property in the Transform component of the GameObject which this script is attached to
        // and assigns to it the value of Player's Transform Position. In this specific case, the Main Camera receives the same position value as the 'Vehicle'.
        // 'offset' variable --> This is needed in order to offset the Main Camera BEHIND the Player. If not added, the camera will be positioned in the same exact position of the Player (Vehicle GameObject).

    }
}
