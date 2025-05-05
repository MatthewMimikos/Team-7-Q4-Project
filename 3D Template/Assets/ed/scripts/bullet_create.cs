using System.Collections;
using TMPro;
using UnityEngine;

public class bullet_create : MonoBehaviour
{
    public GameObject bullet;
    public Transform playertransform;
    public Transform cameratransform;
    public Vector3 raycastpoint;
    public PlayerCam playercamera;
    public WeaponSwitching weapons;
    public TMP_Text ammo_text;

    public int loaded_ammo = 2;
    public int ammo = 8;

    void Start()
    {
        playercamera = FindFirstObjectByType<PlayerCam>();
    }

    void Update()
    {
        ammo_text = GameObject.Find("ammo_text").GetComponent<TMP_Text>();
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            if (weapons.selectedWeapon == 2)
            {
                if (loaded_ammo >= 0 && ammo >= 0)
                {
                    loaded_ammo--;
                    ammo_text.text = loaded_ammo.ToString() + "/" + ammo.ToString();
                    transform.LookAt(playercamera.raycast_point);
                    for (int i = 0; i < 8; i++)
                    {
                        GameObject new_bullet = Instantiate(bullet, new Vector3(transform.position.x, transform.position.y, transform.position.z), transform.rotation);
                        new_bullet.transform.Rotate(Random.Range(-2f, 2f), Random.Range(-2f, 2f), 0);
                    }
                    GameObject game_manager = GameObject.Find("gamemanager");
                    game_manager.GetComponent<gamemanager>().detected("Everyone heard the shotgun fire...");
                }  
                if (loaded_ammo <= 0 && ammo <= 2)
                {
                    ammo_text.text = "Reloading";
                    StartCoroutine(Reload());
                }
            }
        }
    }
    private IEnumerator Reload()
    {
        yield return new WaitForSeconds(3.0f);
        ammo -= 2;
        loaded_ammo = 2;
    }
}
