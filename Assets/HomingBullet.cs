using UnityEngine;

public class HomingBullet : MonoBehaviour
{
    public float speed = 8f;
    private Transform target;
    private Rigidbody rb; 
       
    private void Start()
{
    rb = GetComponent<Rigidbody>();
}
    private void Update()
{
    if (target == null)
    {
        GameObject findGo = GameObject.FindWithTag("Player");

        if (findGo == null)
        {
            return;
        }

        target = findGo.transform;
    }

    Vector3 direction = target.position - transform.position;
    direction.Normalize();

    rb.linearVelocity = direction * speed;
    transform.rotation = Quaternion.LookRotation(direction);
}

    private void OnTriggerEnter(Collider other)
    {
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
