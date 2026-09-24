using UnityEngine;

public class Spin : MonoBehaviour
{
    public float speed = 5f;
    public float rotationSpeed = 270f;

    void Update()
    {
        transform.Rotate(rotationSpeed * Time.deltaTime, 0, 0); 
        transform.Translate(0, speed * Time.deltaTime, 0);
    }
}
