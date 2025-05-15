using UnityEngine;
using UnityEngine.UI;

public class CameraSensitivitySetting : MonoBehaviour
{
    public PlayerCam PlayerCam;
    public Slider Slider;

    void Start()
    {
        if (!PlayerPrefs.HasKey("CameraSensitivity"))
        {
            PlayerPrefs.SetFloat("CameraSensitivity", 1);
            Load();
        }
        else
        {
            Load();
        }
    }

    public void CameraSensitivity()
    {
        PlayerCam.sensX = (Slider.value * 180) + 20;
        PlayerCam.sensY = (Slider.value * 180) + 20;
        Save();
    }

    private void Load()
    {
        Slider.value = PlayerPrefs.GetFloat("CameraSensitivity");
    }

    public void Save()
    {
        PlayerPrefs.SetFloat("CameraSensitivity", Slider.value);
    }
}
