using JetBrains.Annotations;
using UnityEngine;

public class PauseUnpause : MonoBehaviour
{
    public GameObject PauseMenu;
    public KeyCode Pause;
    public PlayerCam playercamera;
    public PlayerMovement PlayerMovement;
    public MaskSwitching MaskSwitching;

    public void Start()
    {
        PauseMenu.SetActive(false);
    }

    public void Unpause()
    {
        Time.timeScale = 1f;
        PauseMenu.SetActive(false);
        playercamera.enabled = true;
        PlayerMovement.enabled = true;
        MaskSwitching.enabled = true;
    }

    public void Update()
    {
        if (Input.GetKey(Pause))
        {
            PauseMenu.SetActive(true);
            Time.timeScale = 0f;
            playercamera.enabled = false;
            PlayerMovement.enabled = false;
            MaskSwitching.enabled = false;
        }
    }
}
