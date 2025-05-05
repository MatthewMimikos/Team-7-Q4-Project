using UnityEngine;

public class SetSettingsActive : MonoBehaviour
{
    public GameObject settingsScene;

    public void Start()
    {
        settingsScene.SetActive(false);
    }
    public void SettingsActive()
    {
        settingsScene.SetActive(true);
    }

    public void SettingsInactive()
    {
        settingsScene.SetActive(false);
    }
}
