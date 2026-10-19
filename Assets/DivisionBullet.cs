using UnityEngine;

public class DivisionBullet : bullet
{
    public GameObject smallPrefab;
    private float divisionTime = 0.5f;
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
        Vector3 direction = transform.forward;     
        
        for (int i = -1; i <= 1; i++)
        {
            Vector3 spawnPosition = position + transform.right * i;
            Vector3 spawnDirection = direction + transform.right * i * 0.5f;

            Quaternion rotation = Quaternion.LookRotation(spawnDirection);
            Instantiate(smallPrefab, spawnPosition, rotation);
        }
        
        Destroy(gameObject);
    }

}
