using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IntroSceneChange : MonoBehaviour
{
    public string thescene;
    public float wait;

    void Start()
    {
        StartCoroutine(IntroSwitch());
    }

    IEnumerator IntroSwitch()
    {
        yield return new WaitForSeconds(wait);
        SceneManager.LoadScene(thescene);
    }
}