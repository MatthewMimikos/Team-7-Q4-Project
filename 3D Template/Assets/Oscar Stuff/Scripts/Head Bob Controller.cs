using Unity.VisualScripting;
using UnityEngine;

public class HeadBobController : MonoBehaviour
{
    public Animator camAnim;

    public void Update()
    {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
        {
            camAnim.SetBool("walk", true);
        }
        else if (Input.GetKey(KeyCode.LeftShift))
        {
            camAnim.SetBool("running", true);
        }
        else
        {
            camAnim.SetBool("walk", false);
        }
    }
}
