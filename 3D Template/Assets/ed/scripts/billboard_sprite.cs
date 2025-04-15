using UnityEngine;
using UnityEngine.Splines;

public class billboard_sprite : MonoBehaviour
{
    public GameObject sprite;
    Vector3 cameradirection;
    
    void Update()
    {
        cameradirection = Camera.main.transform.forward;
        cameradirection.y = 0;
        sprite.transform.rotation = Quaternion.LookRotation(cameradirection);
    }
}
