using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerCam : MonoBehaviour
{
    public float sensX;
    public float sensY;

    public Transform orientation;

    float xRotation;
    float yRotation;

    public int target = 120;

    public bullet_create bullet_Create;
    public ui ui;
    public Vector3 raycast_point;

    private void Awake()
    {
        Application.targetFrameRate = target;
    }

    private void Start()
    {
        ui = FindFirstObjectByType<ui>();
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    private void Update()
    {
        float mouseX = Input.GetAxisRaw("Mouse X") * Time.deltaTime * sensX;
        float mouseY = Input.GetAxisRaw("Mouse Y") * Time.deltaTime * sensY;

        yRotation += mouseX;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        transform.rotation = Quaternion.Euler(xRotation, yRotation, 0);
        orientation.rotation = Quaternion.Euler(0, yRotation, 0);

        Physics.Raycast(transform.position, transform.forward, out RaycastHit HitInfo, 100000f);
        raycast_point = HitInfo.point;
        if (HitInfo.collider.CompareTag("camera"))
        {
            ui.info_text.text = "Security Camera";
            ui.info_text2.text = "Hit with Shovel to disable";
        }
        else if (HitInfo.collider.CompareTag("dropped_shovel"))
        {
            ui.info_text.text = "Shovel";
            ui.info_text2.text = "Press E to pick up";
        }
        else
        {
            ui.info_text.text = "";
            ui.info_text2.text = "";
        }
    }
}