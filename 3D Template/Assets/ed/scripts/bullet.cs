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
        transform.position += transform.forward * 150 * Time.deltaTime;
        transform.Rotate(new Vector3(20 * Time.deltaTime, 0, 0));
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("enemy") && from_enemy == false)
        {
            other.gameObject.GetComponent<enemy>().health -= 25;
        }
    }
    private void Awake()
    {
        Destroy(gameObject, 3f);
    }
}
