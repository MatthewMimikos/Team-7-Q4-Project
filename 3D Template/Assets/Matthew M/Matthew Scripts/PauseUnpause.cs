using JetBrains.Annotations;
using UnityEngine;

public class PauseUnpause : MonoBehaviour
{
    public GameObject PauseMenu;
    public KeyCode Pause;
    public PlayerCam playercamera;
    public PlayerMovement PlayerMovement;
    public MaskSwitching MaskSwitching;
    public MoveCam MoveCam;
    public HeadBobController HeadBobController;
    public Shake Shake;
    public GameObject ui;
    private GameObject target;

    public void Start()
    {
        PauseMenu.SetActive(false);
        target = GameObject.FindGameObjectWithTag("ui");
    }

    public void Unpause()
    {
            Time.timeScale = 1f;
            PauseMenu.SetActive(false);
            playercamera.enabled = true;
            PlayerMovement.enabled = true;
            MaskSwitching.enabled = true;
            MoveCam.enabled = true;
            Shake.enabled = true;
            HeadBobController.enabled = true;
            target.SetActive(true);
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
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
            MoveCam.enabled = false;
            Shake.enabled = false;
            HeadBobController.enabled = false;
            target.SetActive(false);
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
    }
}
