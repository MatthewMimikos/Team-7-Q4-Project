using TMPro;
using UnityEngine;

public class gamemanager : MonoBehaviour
{
    public TMP_Text event_text;
    public bool is_detected = false;
    public GameObject ui;
    public Animator animator;
    public bool cameraguy1alive = true;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public void begingame()
    {
        animator = GameObject.Find("event_text").GetComponent<Animator>();
        event_text = GameObject.Find("event_text").GetComponent<TMP_Text>();
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
            event_text.text = "A guard detected you!";
            animator.SetTrigger("red_text");
            GetComponent<AudioSource>().Play();
        }
    }
    public void DisableCameras()
    {
        detection[] cameras = FindObjectsByType<detection>(FindObjectsSortMode.None);
        for (int i = 0; i < cameras.Length; i++)
        {
            cameras[i].Disable();
        }
        event_text.text = "Camera operator downed, all cameras have been disabled";
        animator.SetTrigger("normal_text");
        cameraguy1alive = false;
    }
}
