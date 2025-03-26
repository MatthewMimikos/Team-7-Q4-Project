using UnityEngine;

public class bullet : MonoBehaviour
{
    public bool from_enemy = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.forward * 120 * Time.deltaTime;
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<enemy>() && from_enemy == false)
        {
            other.gameObject.GetComponent<enemy>().health -= 20;
        }
    }
    private void Awake()
    {
        Destroy(gameObject, 3f);
    }
}
