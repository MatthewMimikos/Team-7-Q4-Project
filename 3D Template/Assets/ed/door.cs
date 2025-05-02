using UnityEngine;

public class door : MonoBehaviour
{

    public Animator animator;
    public GameObject mask_switching;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        mask_switching = (GameObject.Find("Player Parent"));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("enemy"))
        {
            if (other.GetComponent<enemy>().type != 0)
            {
                animator.SetTrigger("open");
            }
        }
        else if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log(mask_switching.GetComponent<MaskSwitching>().currentMask);
            if (mask_switching.GetComponent<MaskSwitching>().currentMask == 2)
            {
                animator.SetTrigger("open");
            }
        }
    }
}
