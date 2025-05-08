using UnityEngine;

public class melee_attack : MonoBehaviour
{
    public bool from_enemy = false;
    public bool already_damaged = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("enemy") && from_enemy == false)
        {
            other.gameObject.GetComponent<enemy>().health -= 100;
        }
        else if (other.gameObject.CompareTag("window"))
        {
            other.gameObject.GetComponent<breakablewindow>().wow();
        }
        else if (other.gameObject.CompareTag("detection"))
        {

        }
        else if (other.gameObject.CompareTag("Player") && already_damaged == false && from_enemy == true)
        {
            already_damaged = true;
            if (from_enemy == true)
            {
                other.gameObject.GetComponent<PlayerMovement>().take_damage(20);
                Destroy(gameObject);
            }
        }
        else if (other.gameObject.CompareTag("enemy"))
        {

        }
    }
    private void Awake()
    {
        Destroy(gameObject, 0.25f);
    }
}
