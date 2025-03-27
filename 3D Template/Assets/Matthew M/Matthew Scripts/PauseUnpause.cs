using UnityEngine;

public class PauseUnpause : MonoBehaviour
{
    public GameObject PauseMenu;
    public KeyCode Pause;

    public void Start()
    {
        PauseMenu.SetActive(false);
    }

    public void Unpause()
    {
        Time.timeScale = 1f;
        PauseMenu.SetActive(false);
    }

    public void Update()
    {
        if (Input.GetKey(Pause))
        {
            PauseMenu.SetActive(true);
            Time.timeScale = 0f;
        }
    }
}
