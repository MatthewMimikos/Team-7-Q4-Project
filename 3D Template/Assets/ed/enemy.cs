using UnityEngine;

public class enemy : MonoBehaviour
{
    Vector3 cameradirection;
    public GameObject sprite;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        cameradirection = Camera.main.transform.forward;
        cameradirection.y = 0;
        
        sprite.transform.rotation = Quaternion.LookRotation(cameradirection);
    }
}
