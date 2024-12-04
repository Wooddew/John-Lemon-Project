using UnityEngine;

public class SimplePlayerSprint : MonoBehaviour
{
    public float normalSpeed = 5f;        
    public float sprintSpeed = 8f;        
    private float currentSpeed;

    private void Update()
    {
        
        if (Input.GetKey(KeyCode.LeftShift))
        {
            currentSpeed = sprintSpeed;
        }
        else
        {
            currentSpeed = normalSpeed;
        }

    
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(horizontal, 0f, vertical).normalized * currentSpeed * Time.deltaTime;
        transform.Translate(movement, Space.World);
    }
}