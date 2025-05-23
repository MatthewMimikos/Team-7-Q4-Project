using System.Collections;
using UnityEngine;

public class Shake : MonoBehaviour
{
    public bool start = false;
    public AnimationCurve curve;
    public float duration = 1.0f;
    // Update is called once per frame
    void Update()
    {
        if (start)
        {
            start = false;
            StartCoroutine(Shaking());
        }
    }

    IEnumerator Shaking()
    {
        Vector3 startPosition = transform.position;
        float elapsedTime = 0f;

        while (elapsedTime < duration)
        {
            elapsedTime += Time.deltaTime;
            float strentgh = curve.Evaluate(elapsedTime / duration);
            transform.position = startPosition + Random.insideUnitSphere * strentgh;
            yield return null;
        }

        transform.position = startPosition;
    }
}
