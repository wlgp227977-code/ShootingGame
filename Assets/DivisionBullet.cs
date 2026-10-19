using UnityEngine;

public class DivisionBullet : bullet
{
    public GameObject smallPrefab;
    private float divisionTime = 1f;
    private float timer = 0;
    

    private void Update() 
    {
        timer += Time.deltaTime;
        if (timer > divisionTime)
        {
            timer = 0;
            Spawn();
        }

    }    

     private void Spawn() 
    {
        Vector3 position = transform.position;        
        Quaternion rotation = transform.rotation;

        Vector3 position1 = position + transform.right;
        Vector3 position2 = position - transform.right;
                
        Instantiate(smallPrefab, position1, rotation);
        Instantiate(smallPrefab, position2, rotation);
        Destroy(gameObject);
    }

}
