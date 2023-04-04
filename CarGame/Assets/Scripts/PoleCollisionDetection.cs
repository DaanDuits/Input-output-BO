using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoleCollisionDetection : MonoBehaviour
{
    public GameObject car;
    public CarMovement carMovement;
    public GameObject particle;

    public float minBreakForce;
    bool isBroken;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject == car && !isBroken)
        {
            if (carMovement.speed > minBreakForce)
            {
                gameObject.AddComponent<Rigidbody>();
                isBroken = true;
                if (particle != null)
                    Instantiate(particle, transform.position, Quaternion.Euler(-90, 0, 0));
            }
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
