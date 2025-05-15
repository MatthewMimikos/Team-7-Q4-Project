using UnityEngine;

public class enemy_spawner : MonoBehaviour
{

    public GameObject enemy;
    public GameObject gamemanager;
    public GameObject thing;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    public void enemy_spawn()
    {
        GameObject new_enemy = Instantiate(enemy, new Vector3(thing.transform.position.x, thing.transform.position.y, thing.transform.position.z), transform.rotation);
    }
}
    // Update is called once per frame
