using UnityEngine;

public class FollowPlayerCamera : MonoBehaviour
{
    public Transform player;
    public float smoothing = 5f;
    Vector3 offset;
    void Start()
    {
        offset = transform.position - player.position;
    }

    void Update()
    {
        Vector3 playerCameraPosition = player.position + offset;
        transform.position = Vector3.Lerp(transform.position, playerCameraPosition, smoothing * Time.deltaTime);
    }
}
