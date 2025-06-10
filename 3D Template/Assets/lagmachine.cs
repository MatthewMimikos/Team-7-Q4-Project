using UnityEngine;

public class lagmachine : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GetComponent<Light>().color = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);
        transform.Rotate(Random.Range(0, 360), Random.Range(0, 360), Random.Range(0, 360));
    }
        // Update is called once per frame
    void Update()
    {
        transform.Rotate(50 * Time.deltaTime, 50 * Time.deltaTime, 50 * Time.deltaTime);
    }
}
