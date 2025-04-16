using UnityEngine;
using UnityEngine.UI;

public class detection : MonoBehaviour
{
    public bool can_see_player = false;
    private GameObject player;
    public GameObject detection_visual;
    private ui ui;
    public GameObject actual_camera;
    public GameObject player_camera;

    public GameObject my_detection_visual;
    private float detection_amount = 0;
    private bool fully_detected = false;

    private bool is_camera = false;
    private bool disabled = false;
    private GameObject gamemanager;

    private Animator animator;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (GetComponent<Camera>() != null)
        {
            is_camera = true;
        }
        gamemanager = GameObject.Find("gamemanager");
        player = GameObject.Find("Player");
        player_camera = GameObject.Find("PlayerCam");
    }

    // Update is called once per frame
    void Update()
    {
        if (can_see_player)
        {
            if (Physics.Raycast(actual_camera.transform.position, player.transform.position - actual_camera.transform.position, out RaycastHit hitInfo, 50f))
            {
                if (hitInfo.transform.gameObject.CompareTag("Player"))
                {
                    if (my_detection_visual == null && !disabled)
                    {
                        ui = FindFirstObjectByType<ui>();
                        GameObject new_detection = Instantiate(detection_visual, ui.transform.position, Quaternion.identity);
                        animator = new_detection.GetComponentInChildren<Animator>();
                        new_detection.transform.SetParent(ui.crosshair.transform);
                        my_detection_visual = new_detection.gameObject;
                    }
                    if (!fully_detected && gamemanager.GetComponent<gamemanager>().cameraguy1alive)
                    {
                        Vector3 direction = actual_camera.transform.position - player.transform.position;
                        Quaternion rotation = Quaternion.LookRotation(direction);
                        my_detection_visual.transform.rotation = Quaternion.Euler(0, 0, -rotation.eulerAngles.y + player_camera.transform.eulerAngles.y);
                        detection_amount += 0.3f * Time.deltaTime;
                        detection_amount = Mathf.Clamp(detection_amount, 0, 1);
                        animator.ForceStateNormalizedTime(detection_amount);
                        my_detection_visual.GetComponentInChildren<Image>().color = new Color32(255, 255, 225, (byte)(detection_amount * 255));
                        if (detection_amount >= 0.999f)
                        {
                            fully_detected = true;
                        }
                    }
                    if (fully_detected)
                    {
                        gamemanager.GetComponent<gamemanager>().detected();
                        Vector3 direction = actual_camera.transform.position - player.transform.position;
                        Quaternion rotation = Quaternion.LookRotation(direction);
                        my_detection_visual.transform.rotation = Quaternion.Euler(0, 0, -rotation.eulerAngles.y + player_camera.transform.eulerAngles.y);
                        my_detection_visual.GetComponentInChildren<Image>().color = new Color32(255, 0, 0, 255);
                    }
                }
                else
                {
                    Vector3 direction = actual_camera.transform.position - player.transform.position;
                    Quaternion rotation = Quaternion.LookRotation(direction);
                    my_detection_visual.transform.rotation = Quaternion.Euler(0, 0, -rotation.eulerAngles.y + player_camera.transform.eulerAngles.y);
                    detection_amount -= 0.1f * Time.deltaTime;
                    detection_amount = Mathf.Clamp(detection_amount, 0, 1);
                    animator.ForceStateNormalizedTime(detection_amount);
                    my_detection_visual.GetComponentInChildren<Image>().color = new Color32(255, 255, 225, (byte)(detection_amount * 255));
                }
            }
        }
        if (!can_see_player && detection_amount != 0 && my_detection_visual != null)
        {
            Vector3 direction = actual_camera.transform.position - player.transform.position;
            Quaternion rotation = Quaternion.LookRotation(direction);
            Debug.Log(rotation.eulerAngles);
            my_detection_visual.transform.rotation = Quaternion.Euler(0, 0, -rotation.eulerAngles.y + player_camera.transform.eulerAngles.y);
            detection_amount -= 0.1f * Time.deltaTime;
            detection_amount = Mathf.Clamp(detection_amount, 0, 1);
            animator.ForceStateNormalizedTime(detection_amount);
            my_detection_visual.GetComponentInChildren<Image>().color = new Color32(255, 255, 225, (byte)(detection_amount * 255));
        }
        if (detection_amount == 0 && my_detection_visual != null)
        {
            Destroy(my_detection_visual.gameObject);
        }
    }
    private void OnDrawGizmos()
    {
        if (can_see_player)
        {
            Gizmos.DrawLine(actual_camera.transform.position, player.transform.position - actual_camera.transform.position * 50f);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            can_see_player = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            can_see_player = false;    
        }
    }
    public void Disable()
    {
        if (is_camera)
        {
            disabled = true;
        }
    }
}
