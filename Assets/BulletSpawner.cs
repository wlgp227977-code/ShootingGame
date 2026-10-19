using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public GameObject[] bulletPrefab;
    private Transform target;
    private float interval = 1f;
    private float timer = 0;

    private void Start()
    {
        GameObject findGo = GameObject.FindWithTag("Player");
        target = findGo.transform;
    }

    private void Update() 
    {
        timer += Time.deltaTime;
        if (timer > interval)
        {
            timer = 0;
            Spawn();
        }

    }

    private void Spawn() 
    {
        Vector3 position = transform.position;
        Vector3 direction = (target.position - transform.position);
        direction.Normalize();


        Quaternion rotation = Quaternion.LookRotation(direction);
        int random = Random.Range(0, bulletPrefab.Length);
        Instantiate(bulletPrefab[random], position, rotation);

    }
}
