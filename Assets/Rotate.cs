using UnityEngine;

public class Rotate : MonoBehaviour
{
    public float rotSpeed = 360f;
    void Update()
    {
        transform.Rotate(0f, rotSpeed * Time.deltaTime, 0f); // Time.deltaTime을 안 곱하면 프레임마다 한바퀴 돌아버림
    }
}
