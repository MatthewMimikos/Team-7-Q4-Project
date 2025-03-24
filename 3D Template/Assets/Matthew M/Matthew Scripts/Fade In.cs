using System.Collections;
using UnityEngine;

public class FadeIn : MonoBehaviour
{

    public float WaitTime;
    public GameObject Image;

    void Start()
    {
        StartCoroutine(FadesIn());
    }

    IEnumerator FadesIn()
    {
        Image.SetActive(true);
        yield return new WaitForSeconds(WaitTime);
        Image.SetActive(false);
    }
}
