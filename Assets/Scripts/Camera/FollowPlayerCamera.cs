using UnityEngine;

public class FollowPlayerCamera : MonoBehaviour
{
    public Transform player;
    public float smoothing = 5f;
    Vector3 offset;
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
        Vector3 playerCameraPosition = player.position + offset;
        transform.position = Vector3.Lerp(transform.position, playerCameraPosition, smoothing * Time.deltaTime);
    }
}
