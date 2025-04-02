using UnityEngine;

public class gamemanager : MonoBehaviour
{
    public bool is_detected = false;
    private GameObject ui;
    public Animator animator;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    private void Start()
    {
        ui = GameObject.Find("ui");
    }
    public void detected()
    {
        PlayMusic();
        is_detected = true;
        red_light_alarm[] lights = FindObjectsByType<red_light_alarm>(FindObjectsSortMode.None);
        for (int i = 0; i < lights.Length; i++)
        {
            lights[i].turnon();
        }
    }
    public void PlayMusic()
    {
        if (!is_detected)
        {
            Debug.Log("detected");
            animator.SetTrigger("event text");
            GetComponent<AudioSource>().Play();
        }
    }
}
