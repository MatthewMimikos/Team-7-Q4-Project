using System.Collections;
using TMPro;
using UnityEngine;

public class bullet_create : MonoBehaviour
{
    public Animator shotgun_anim;
    public Animator shovel_anim;
    public AudioSource AudioSource;
    public AudioSource AudioSource1;
    public AudioSource AudioSource2;
    public GameObject bullet;
    public GameObject attack;
    public Transform playertransform;
    public Transform cameratransform;
    public Vector3 raycastpoint;
    public PlayerCam playercamera;
    public WeaponSwitching weapons;
    public TMP_Text ammo_text;

    public bool shovel_cooldown = false;
    public int loaded_ammo = 2;
    public int ammo = 8;

    void Start()
    {
        playercamera = FindFirstObjectByType<PlayerCam>();
    }

    void Update()
    {
        ammo_text = GameObject.Find("ammo_text").GetComponent<TMP_Text>();
        transform.LookAt(playercamera.raycast_point);
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            if (weapons.selectedWeapon == 2)
            {
                if (loaded_ammo > 0 && ammo >= 0)
                {
                    shotgun_anim.SetTrigger("shoot");
                    loaded_ammo--;
                    ammo_text.text = loaded_ammo.ToString() + "/" + ammo.ToString();
                    AudioSource.Play();
                    for (int i = 0; i < 8; i++)
                    {
                        GameObject new_bullet = Instantiate(bullet, new Vector3(transform.position.x, transform.position.y, transform.position.z), transform.rotation);
                        new_bullet.GetComponent<bullet>().from_enemy = false;
                        new_bullet.transform.Rotate(Random.Range(-2f, 2f), Random.Range(-2f, 2f), 0);
                    }
                    GameObject game_manager = GameObject.Find("gamemanager");
                    game_manager.GetComponent<gamemanager>().detected("Everyone heard the shotgun fire...");
                }
                if (loaded_ammo == 0 && ammo == 0)
                {

                }
                else if (loaded_ammo <= 0 && ammo >= 2 && ammo_text.text != "Reloading")
                {
                    ammo_text.text = "Reloading";
                    StartCoroutine(Reload());
                }
            }
            Debug.Log(weapons.selectedWeapon);
            Debug.Log(shovel_cooldown);
            if (weapons.selectedWeapon == 1 && shovel_cooldown == false)
            {
                shovel_anim.SetTrigger("attack");
                GameObject melee_attack_thing = Instantiate(attack, new Vector3(transform.position.x, transform.position.y, transform.position.z), transform.rotation);
                melee_attack_thing.GetComponent<melee_attack>().from_enemy = false;
                StartCoroutine(Swing());
            }
        }
    }
    private IEnumerator Reload()
    {
        shotgun_anim.SetTrigger("reload");
        yield return new WaitForSeconds(1.2f);
        ammo -= 2;
        loaded_ammo = 2;
        ammo_text.text = loaded_ammo.ToString() + "/" + ammo.ToString();
    }
    private IEnumerator Swing()
    {
        shovel_cooldown = true;
        yield return new WaitForSeconds(1f);
        shovel_cooldown = false;
    }
}
