using UnityEngine;

public class bullet_create : MonoBehaviour
{
    public GameObject bullet;
    public Transform playertransform;
    public Transform cameratransform;
    public Vector3 raycastpoint;
    public PlayerCam playercamera;
    public WeaponSwitching weapons;
    void Start()
    {
        playercamera = FindFirstObjectByType<PlayerCam>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            if (weapons.selectedWeapon == 2)
            {
                transform.LookAt(playercamera.raycast_point);
                for (int i = 0; i < 8; i++)
                {
                    GameObject new_bullet = Instantiate(bullet, new Vector3(transform.position.x, transform.position.y, transform.position.z), transform.rotation);
                    new_bullet.transform.Rotate(Random.Range(-2f, 2f), Random.Range(-2f, 2f), 0);
                }
            }
        }
    }
}
