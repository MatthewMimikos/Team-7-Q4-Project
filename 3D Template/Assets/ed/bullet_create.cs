using UnityEngine;

public class bullet_create : MonoBehaviour
{
    public GameObject bullet;
    public Transform playertransform;
    public Transform cameratransform;
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            for (int i = 0; i < 8; i++)
            {
                GameObject new_bullet = Instantiate(bullet, new Vector3(playertransform.position.x, playertransform.position.y - 0.3f, playertransform.position.z), cameratransform.rotation);
                new_bullet.transform.Rotate(Random.Range(-2, 2), Random.Range(-2, 2), 0);
        }
        }
    }
}
