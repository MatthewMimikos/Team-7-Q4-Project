using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoadBasic : MonoBehaviour
{

    public float WaitTime;
    public string scene;
    public GameObject Image;

    public void Awake()
    {
        Image.SetActive(false);
    }

    public void LoadScene()
    {
        SceneManager.LoadScene(scene);
    }

    public void UniqueExit()
    {
        Time.timeScale = 1;
        Invoke("LoadScene", WaitTime);
        Image.SetActive(true);
    }

    public void End()
    {
        Application.Quit();
    }
}
