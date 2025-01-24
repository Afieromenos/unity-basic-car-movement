using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 13.0f;
    private float turnspeed=1;
    private float horizontalInput;
    private float verticalInput;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //user input
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        //move forward tank
        transform.Translate(Vector3.forward * Time.deltaTime * verticalInput * speed);
        
        transform.Rotate(Vector3.up,  turnspeed * horizontalInput);

    }
}
