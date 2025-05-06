using UnityEngine;

public class pickup : MonoBehaviour
{
    public bool dynamite = false;
    public bool shell = false;
    public bool miner_mask = false;
    public bool guard_mask = false;
    public bool camera_mask = false;
    public bool speed_mask = false;
    public bool shovel_mask = false;

    public void picked_up()
    {
        if (dynamite)
        {

        }
        if (shell)
        {

        }
        Destroy(gameObject);
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    // Update is called once per frame
}