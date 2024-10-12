using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField]private Transform player;



    // Update is called once per frame
    // Transforms the position of the camera to keep up with the player rather than stay fixed in a position.
    private void Update()
    {
        transform.position = new Vector3(player.position.x, player.position.y, transform.position.z);   
    }
}
