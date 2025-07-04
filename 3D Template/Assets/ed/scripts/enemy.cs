using System.Collections;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Rendering;
using UnityEngine.Rendering.HighDefinition;

public class enemy : MonoBehaviour
{
    public int preset_type = -1;
    public Animator sprite_thing;

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
    public LayerMask layerMask;

    public GameObject player_position;

    public bool dead;
    Vector3 prev_position;
    Vector3 moving_direction;

    public GameObject miner_mask;
    public GameObject guard_mask;

    public bool fear;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        prev_position = transform.position;
        moving_direction = Vector3.zero;
        gamemanager = GameObject.Find("gamemanager");
        player = GameObject.Find("Player");
        if (preset_type == -1)
        {
            type = Random.Range(3, 3);
        }
        else
        {
            type = preset_type;
        }
        miner.SetActive(false);
        guard.SetActive(false);
        elite_guard.SetActive(false);
        rifle.SetActive(false);
        cultmember.SetActive(false);
        coolcultmember.SetActive(false);
        if (type == 0)
        {
            miner.SetActive(true);
            sprite_thing = miner.GetComponent<Animator>();
            GetComponent<billboard_sprite>().sprite = miner;
            health = 50;
        }
        else if (type == 1)
        {
            gamemanager.GetComponent<gamemanager>().enemies_left += 1;
            guard.SetActive(true);
            sprite_thing = guard.GetComponent<Animator>();
            GetComponent<billboard_sprite>().sprite = guard;
            health = 125;
        }
        else if (type == 2)
        {
            gamemanager.GetComponent<gamemanager>().enemies_left += 1;
            elite_guard.SetActive(true);
            sprite_thing = elite_guard.GetComponent<Animator>();
            GetComponent<billboard_sprite>().sprite = elite_guard;
            health = 325;
        }
        else if (type == 3)
        {
            gamemanager.GetComponent<gamemanager>().enemies_left += 1;
            rifle.SetActive(true);
            sprite_thing = rifle.GetComponent<Animator>();
            GetComponent<billboard_sprite>().sprite = rifle;
            health = 100;
        }
        else if (type == 4)
        {
            gamemanager.GetComponent<gamemanager>().enemies_left += 1;
            cultmember.SetActive(true);
            sprite_thing = cultmember.GetComponent<Animator>();
            GetComponent<billboard_sprite>().sprite = cultmember;
            health = 125;
        }
        else if (type == 5)
        {
            gamemanager.GetComponent<gamemanager>().enemies_left += 1;
            coolcultmember.SetActive(true);
            sprite_thing = coolcultmember.GetComponent<Animator>();
            GetComponent<billboard_sprite>().sprite = coolcultmember;
            health = 200;
        }
        sprite_thing.SetTrigger("walk");
    }

    // Update is called once per frame
    void Update()
    {
        player_position.transform.LookAt(player.transform.position);
        if (transform.position != prev_position)
        {
            moving_direction = (transform.position - prev_position).normalized;
            prev_position = transform.position;
        }
        if (health <= 0 && !dead)
        {
            dead = true;
            if (type != 0)
            {
                GameObject new_mask = Instantiate(guard_mask, new Vector3(transform.position.x, transform.position.y, transform.position.z), transform.rotation);
                gamemanager.GetComponent<gamemanager>().enemies_left -= 1;
                gamemanager.GetComponent<gamemanager>().score += 1;
            }
            if (type == 0)
            {
                gamemanager.GetComponent<gamemanager>().score -= 10;
            }
            sprite_thing.SetTrigger("die");
        }

        if (gamemanager.GetComponent<gamemanager>().is_detected && player.GetComponent<PlayerMovement>().health >= 0)
        {
            if (type == 0 && fear == false)
            {
                fear = true;
                sprite_thing.SetTrigger("fear");
            }
            if (can_attack == true && type != 0)
            {
                if (type == 1)
                {

                }
                if (type == 3)
                {
                    bool did_hit = Physics.Linecast(transform.position, player.transform.position, out RaycastHit hitInfo, layerMask);
                    if (did_hit && hitInfo.transform.gameObject.CompareTag("Player"))
                    {
                        StartCoroutine(EnterCooldown());
                    }
                }
            }
        }
        if (gamemanager.GetComponent<gamemanager>().is_detected == true && type != 0 && !dead && can_attack)
        {
            navigation.destination = player.transform.position;
        }
    }


    private IEnumerator EnterCooldown()
    {
        sprite_thing.SetTrigger("attack");
        can_attack = false;
        navigation.enabled = false;
        yield return new WaitForSeconds(1.9f);
        bool did_hit = Physics.Linecast(transform.position, player.transform.position, out RaycastHit hitInfo, layerMask);
        if (did_hit && hitInfo.transform.gameObject.CompareTag("Player") && !dead)
        {
            sprite_thing.GetComponent<AudioSource>().Play();
            GameObject new_bullet = Instantiate(bullet, new Vector3(attack_transform.transform.position.x, attack_transform.transform.position.y - 0.15f, attack_transform.transform.position.z), Quaternion.identity);
            new_bullet.GetComponent<bullet>().from_enemy = true;
            new_bullet.transform.LookAt(player.transform.position);
            new_bullet.transform.Rotate(Random.Range(-4f, 0f), Random.Range(-1f, 1f), 0);
        }
        else
        {
            sprite_thing.SetTrigger("walk");
        }
        yield return new WaitForSeconds(0.5f);
        can_attack = true;
        navigation.enabled = true;
    }
}
