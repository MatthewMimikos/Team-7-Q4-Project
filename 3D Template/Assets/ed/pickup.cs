using UnityEngine;

public class pickup : MonoBehaviour
{
    public bool dynamite = false;
    public bool shell = false;

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