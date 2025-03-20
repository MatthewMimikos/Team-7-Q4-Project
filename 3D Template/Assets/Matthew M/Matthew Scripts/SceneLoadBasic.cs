using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoadBasic : MonoBehaviour
{

    public string scene;

    public void LoadScene()
    {
        SceneManager.LoadScene(scene);
    }

    public void End()
    {
        Application.Quit();
    }
}
