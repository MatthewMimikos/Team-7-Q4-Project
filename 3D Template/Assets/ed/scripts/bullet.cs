using UnityEngine;

public class bullet : MonoBehaviour
{
    public bool from_enemy = false;
    public GameObject player;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.forward * 100 * Time.deltaTime;
        transform.Rotate(new Vector3(20 * Time.deltaTime, 0, 0));
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("enemy") && from_enemy == false)
        {
            other.gameObject.GetComponent<enemy>().health -= 25;
        }
        else if (other.gameObject.CompareTag("window"))
        {
            other.gameObject.GetComponent<breakablewindow>().wow();
        }
        else if (other.gameObject.CompareTag("detection"))
        {
            
        }
        else if (other.gameObject.CompareTag("Player"))
        {
            if (from_enemy == true)
            {
                other.gameObject.GetComponent<PlayerMovement>().take_damage(20);
                Destroy(gameObject);
            }
        }
        else if (other.gameObject.CompareTag("enemy"))
        {

        }
        else
        {
            Destroy(gameObject);
        }
    }
    private void Awake()
    {
        Destroy(gameObject, 3f);
    }
}
