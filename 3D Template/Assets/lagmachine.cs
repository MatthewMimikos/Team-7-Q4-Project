using UnityEngine;

public class lagmachine : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        foreach (Transform child in transform.parent)
        {
            child.GetComponent<Light>().color = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);
            child.transform.Rotate(Random.Range(0, 360), Random.Range(0, 360), Random.Range(0, 360));
        }
    }
        // Update is called once per frame
    void Update()
    {
        foreach (Transform child in transform.parent)
        {
            child.transform.Rotate(5 * Time.deltaTime, 0, 0);
        }
    }
}
