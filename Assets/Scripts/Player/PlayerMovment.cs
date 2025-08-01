using UnityEngine;
using UnityEngine.Rendering;

public class PlayerMovment : MonoBehaviour
{
    [SerializeField] private float speed = 8f;
    private Vector3 movment;
    private Rigidbody playersRb;
    private int floorMask;
    private float camRayLength = 100f;

    [SerializeField] private string playerHorizontalInput = "Horizontal";
    [SerializeField] private string playerVerticalInput = "Vertical";
    [SerializeField] private string floor = "Floor";

    void Start()
    {
        playersRb = GetComponent<Rigidbody>();
        floorMask = LayerMask.GetMask(floor);
    }


    void FixedUpdate()
    {
        float horizontalInput = Input.GetAxis(playerHorizontalInput);
        float verticalInput = Input.GetAxis(playerVerticalInput);
        MovingPlayer(horizontalInput, verticalInput);
        TurningPlayer();
    }

    public void MovingPlayer(float horizontalInput, float verticalInput)
    {
        movment.Set(horizontalInput, 0f, verticalInput);
        movment = movment.normalized * speed * Time.deltaTime;
        playersRb.MovePosition(transform.position + movment);
    }

    public void TurningPlayer()
    {
        Ray camRay = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit floorHit;
        if(Physics.Raycast(camRay, out floorHit, camRayLength, floorMask))
        {
            Vector3 playerToMouse = floorHit.point - transform.position;
            playerToMouse.y = 0f;
            Quaternion newRotation = Quaternion.LookRotation(playerToMouse);
            playersRb.MoveRotation(newRotation);
        }
    }
}
