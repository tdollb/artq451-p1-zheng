using UnityEngine;

public class bobby : MonoBehaviour
{
    public float rate = 3f;
    public float travel = 5f;

    void Start()
    {
        
    }
    void Update()
    {
        float wave = Mathf.Sin(Time.time * rate) * travel;
        transform.Translate(0, wave * Time.deltaTime, 0);

    }
}
