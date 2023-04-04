using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheelRotation : MonoBehaviour
{
    public CarMovement car;
    public bool isFrontwheel;

    // Update is called once per frame
    void Update()
    {
        transform.eulerAngles = new Vector3(car.transform.eulerAngles.x, transform.eulerAngles.y, transform.eulerAngles.z + -car.speed * 25 * Time.deltaTime);
        if (isFrontwheel)
        {
            float inputX = Input.GetAxisRaw("Horizontal");
            if (inputX < 0)
                transform.rotation = Quaternion.Euler(car.transform.eulerAngles.x, -25, transform.eulerAngles.z);
            else if (inputX > 0)
                transform.rotation = Quaternion.Euler(car.transform.eulerAngles.x, 25, transform.eulerAngles.z);
            else if (transform.eulerAngles.y != 0)
                transform.rotation = Quaternion.Euler(car.transform.eulerAngles.x, 0, transform.eulerAngles.z);
        }
    }
}
