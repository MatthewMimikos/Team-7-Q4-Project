using System.Collections;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Rendering;

public class enemy : MonoBehaviour
{
    public GameObject player;
    public GameObject bullet;

    private bool can_attack = true;
    public bool is_camera_guy = false;
    public GameObject attack_transform;

    public GameObject miner;
    public GameObject guard;
    public GameObject elite_guard;
    public GameObject rifle;
    public GameObject cultmember;
    public GameObject coolcultmember;
    public int health = 100;
    public int type = 0;
    private GameObject gamemanager;
    public detection detection;

    public NavMeshAgent navigation;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gamemanager = GameObject.Find("gamemanager");
        player = GameObject.Find("Player");
        type = Random.Range(0, 6);
        miner.SetActive(false);
        guard.SetActive(false);
        elite_guard.SetActive(false);
        rifle.SetActive(false);
        cultmember.SetActive(false);
        coolcultmember.SetActive(false);
        if (type == 0)
        {
            miner.SetActive(true);
            GetComponent<billboard_sprite>().sprite = miner;
            health = 50;
        }
        if (type == 1)
        {
            guard.SetActive(true);
            GetComponent<billboard_sprite>().sprite = guard;
            health = 125;
        }
        if (type == 2)
        {
            elite_guard.SetActive(true);
            GetComponent<billboard_sprite>().sprite = elite_guard;
            health = 325;
        }
        if (type == 3)
        {
            rifle.SetActive(true);
            GetComponent<billboard_sprite>().sprite = rifle;
            health = 100;
        }
        if (type == 4)
        {
            cultmember.SetActive(true);
            GetComponent<billboard_sprite>().sprite = cultmember;
            health = 125;
        }
        if (type == 5)
        {
            coolcultmember.SetActive(true);
            GetComponent<billboard_sprite>().sprite = coolcultmember;
            health = 200;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (health <= 0)
        {
            if (is_camera_guy)
            {
                gamemanager.GetComponent<gamemanager>().DisableCameras();
            }
            if (detection.my_detection_visual != null)
            {
                Destroy(detection.my_detection_visual);
            }
            Destroy(gameObject);
        }

        if (gamemanager.GetComponent<gamemanager>().is_detected)
        {
            if (can_attack == true && type == 1 || can_attack == true && type == 2)
            {
                for (int i = 0; i < 8; i++)
                {
                    GameObject new_bullet = Instantiate(bullet, new Vector3(attack_transform.transform.position.x, attack_transform.transform.position.y - 0.15f, attack_transform.transform.position.z), Quaternion.identity);
                    new_bullet.GetComponent<bullet>().from_enemy = true;
                    new_bullet.transform.LookAt(player.transform.position);
                    new_bullet.transform.Rotate(Random.Range(-5f, 5f), Random.Range(-5f, 5f), 0);
                }
                StartCoroutine(EnterCooldown());
            }
        }
        if (gamemanager.GetComponent<gamemanager>().is_detected == true)
        {
            navigation.destination = player.transform.position;
        }
    }

    private IEnumerator EnterCooldown()
    {
        can_attack = false;
        yield return new WaitForSeconds(0.5f);
        can_attack = true;
    }
}
