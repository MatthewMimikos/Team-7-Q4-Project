using UnityEngine;
using System.Collections;

public class dynamite : MonoBehaviour
{
    public ParticleSystem ParticleSystem;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //StartCoroutine(explode());
    }

    // Update is called once per frame
    void Update()
    {

    }
    private IEnumerator explode()
    {
        yield return new WaitForSeconds(1.0f);
        ParticleSystem.Emit(20);
        //GameObject.Find("PlayerCam").GetComponent<Shake>().start = true;
        yield return new WaitForSeconds(1.0f);
        Destroy(gameObject);
    }
}
