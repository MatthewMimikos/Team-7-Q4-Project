using UnityEngine;

public class bullet_create : MonoBehaviour
{
    public GameObject bullet;
    public Transform playertransform;
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            GameObject new_bullet = Instantiate(bullet, new Vector3(playertransform.position.x, playertransform.position.y, playertransform.position.z), playertransform.rotation);
        }
    }
}
