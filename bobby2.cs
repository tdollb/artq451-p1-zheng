using UnityEngine;

public class bobby2 : MonoBehaviour
{
    public float rate = 3f;
    public float travelnegative = -5f;

    void Start()
    {

    }
    void Update()
    {
        float wave = Mathf.Sin(Time.time * rate) * travelnegative;
        transform.Translate(0, wave * Time.deltaTime, 0);

    }
}
