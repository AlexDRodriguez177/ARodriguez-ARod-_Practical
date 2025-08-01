using UnityEngine;

public class FollowPlayerCamera : MonoBehaviour
{
    public Transform player;
    public float smoothing = 5f;
    private Vector3 offset;
    private float rotationSpeed = 3f;

    /// <summary>
    /// Sets the offset between the camera and the player 
    /// Camera will stay at the position while following the player
    /// </summary>
    void Start()
    {
        offset = transform.position - player.position;
    }
    /// <summary>
    /// Creates a smooth transition when following the player 
    /// Creates a new position bassed off the player and offset
    /// Usng Lerp to create a smooth transition
    /// </summary>
    void Update()
    {
        //RotateCamera();
        Vector3 playerCameraPosition = player.position + offset;
        transform.position = Vector3.Lerp(transform.position, playerCameraPosition, smoothing * Time.deltaTime);
        //transform.LookAt(player);
    }

    private void RotateCamera()
    {
        float mousePosition = Input.GetAxis("Mouse X");

        transform.RotateAround(player.position, Vector3.up, mousePosition * rotationSpeed);

        
    }
}
