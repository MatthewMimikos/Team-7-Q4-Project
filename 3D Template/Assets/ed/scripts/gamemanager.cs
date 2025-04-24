using System.Collections;
using TMPro;
using UnityEngine;

public class gamemanager : MonoBehaviour
{
    public TMP_Text event_text;
    public TMP_Text status_text;
    public bool is_detected = false;
    public bool is_dead = false;
    public GameObject ui;
    public GameObject game_over;
    public Animator animator;
    public bool cameraguy1alive = true;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public void begingame()
    {
        animator = GameObject.Find("event_text").GetComponent<Animator>();
        event_text = GameObject.Find("event_text").GetComponent<TMP_Text>();
        status_text = GameObject.Find("status_text").GetComponent<TMP_Text>();
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
            GetComponent<AudioSource>().time = 31.75f;
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
    public void switch_mask(int mask_id)
    {
        if (mask_id == 1)
        {
            status_text.text = "Disguised as Miner";
            status_text.color = Color.white;
        }
        if (mask_id == 2)
        {
            status_text.text = "Disguised as Guard";
            status_text.color = Color.white;
        }
        if (mask_id == 3)
        {
            status_text.text = "Wrong Mask, Not Disguised";
            status_text.color = Color.red;
        }
        if (mask_id == 4)
        {
            status_text.text = "No Mask, Not Disguised";
            status_text.color = Color.red;
        }
    }
    public void dead()
    {
        if (is_dead == false)
        {
            is_dead = true;
            game_over.GetComponent<GameOverTrigger>().Death = true;
            StartCoroutine(Tween(GetComponent<AudioSource>().pitch, 1f, 0.6f));
        }
    }

    public void diologue(string diologue)
    {
        event_text.text = "Maurice: " + diologue;
        animator.SetTrigger("normal_text");
    }
    private IEnumerator Tween(float pitch, float posA, float posB)
    {
        for (int i = 0; i <= 100; ++i)
        {
            float sound_pitch = Mathf.Lerp(posA, posB, i / 100f);
            GetComponent<AudioSource>().pitch = sound_pitch;
            yield return new WaitForSeconds(0.03f);
        }
    }
}
