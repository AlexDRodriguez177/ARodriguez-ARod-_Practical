using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    public GameObject bulletPrefab;
    public int bulletSpeed = 50;
    private float bulletLife = 3f;
    private Rigidbody bulletRigidbody;

    private void Start()
    {
     
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0) || Input.GetKeyDown(KeyCode.Space))
        {
            GameObject bullet = Instantiate(bulletPrefab, transform.position + transform.forward, transform.rotation);
            bulletRigidbody = bullet.GetComponent<Rigidbody>();
            bulletRigidbody.AddForce (transform.forward * bulletSpeed, ForceMode.Impulse);
            Destroy(bullet, bulletLife);
        }
    }


}
