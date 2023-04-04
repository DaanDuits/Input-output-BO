using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMovement : MonoBehaviour
{
    public float carAcceleration;
    public float brakeSpeed;
    public float maxSpeed;
    public float maxBackwardsSpeed;

    public float rotationSpeed = 10;

    [HideInInspector]
    public float speed;

    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float inputY = Input.GetAxisRaw("Vertical");
        float inputX = Input.GetAxisRaw("Horizontal");

        if (inputY < 0)
            speed -= carAcceleration * Time.deltaTime;
        else if (inputY > 0)
            speed += carAcceleration * Time.deltaTime;
        if (inputY == 0 && speed > 0)
            speed -= Time.deltaTime;
        else if (inputY == 0 && speed < 0)
            speed += Time.deltaTime;
        if (inputY < 0 && speed > 0)
            speed -= carAcceleration * Time.deltaTime * brakeSpeed;
        speed = Mathf.Clamp(speed, -maxBackwardsSpeed, maxSpeed);

        transform.position += (transform.right - new Vector3(0, transform.right.y, 0)) * speed * Time.fixedDeltaTime;

        if (speed != 0)
            transform.rotation = Quaternion.Euler(transform.eulerAngles.x, transform.eulerAngles.y + inputX * Time.fixedDeltaTime * rotationSpeed  * speed, transform.eulerAngles.z);
    }
}
