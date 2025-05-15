using Unity.VisualScripting;
using UnityEngine;

public class Dashing : MonoBehaviour
{
    public Transform orientation;
    public Transform playerCam;
    private Rigidbody rb;
    private PlayerMovement pm;

    public float dashForce;
    public float dashDuration;

    public float dashCd;
    private float dashCdTimer;

    public KeyCode dashKey = KeyCode.R;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        pm = GetComponent<PlayerMovement>();

    }
    private void Update()
    {
        if(Input.GetKeyDown(dashKey))
            Dash();

        if(dashCdTimer > 0) 
            dashCdTimer -= Time.deltaTime;
    }

    private void Dash()
    {
        if (dashCdTimer > 0) return;
        else dashCdTimer = dashCd;

            pm.dashing = true;

        Vector3 forceToApply = orientation.forward * dashForce;

        delayedForceToApply = forceToApply;
        Invoke(nameof(delayedForceToApply), 0.025f);

        Invoke(nameof(ResetDash), dashDuration);
    }
    private Vector3 delayedForceToApply;
    private void DelayedDashForce()
    {
        rb.AddForce(delayedForceToApply, ForceMode.Impulse);
    }
    private void ResetDash()
    {
        pm.dashing = false;
    }
}
