using UnityEngine;
using UnityEngine.Rendering;

public class PlayerMovment : MonoBehaviour
{
    [SerializeField] private float speed = 8f;
    [SerializeField] private float turnSpeed = 180f;

    [SerializeField] private const string playerHorizontalInput = "Horizontal";
    [SerializeField] private const string playerVerticalInput = "Vertical";
    [SerializeField] private const string floor = "Floor";
    [SerializeField] private const string cameraRotation = "Mouse X";

    void Update()
    {
        CameraRotation();
        PlayerMovement();
    }

    void CameraRotation()
    {
        float mouseX = Input.GetAxis(cameraRotation);
        transform.Rotate(Vector3.up, mouseX * turnSpeed * Time.deltaTime);
    }

    void PlayerMovement()
    {
        float horizontalInput = Input.GetAxis(playerHorizontalInput);
        float verticalInput = Input.GetAxis(playerVerticalInput);
        transform.position += (transform.forward * verticalInput + transform.right * horizontalInput) * speed * Time.deltaTime;
    }


}
