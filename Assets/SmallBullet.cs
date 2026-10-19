using UnityEngine;

public class SmallBullet : MonoBehaviour
{
    public float speed = 8f;
    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.linearVelocity= transform.forward * speed;
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.name);
        if (other.CompareTag("Player"))
        {
           PlayerControl playerControl = other.GetComponent<PlayerControl>();
           playerControl.OnDie();
        }

        if (!other.CompareTag("Bullet"))
        {
            Destroy(gameObject);
        }
        
    }
}
