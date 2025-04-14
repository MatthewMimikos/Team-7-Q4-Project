using UnityEngine;

public class red_light_alarm : MonoBehaviour
{
    public GameObject lights;
    public void turnon()
    {
        lights.SetActive(true);
    }
}
