using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMover : MonoBehaviour
{
    public float movementSpeed;
    public float movementDir;
    bool move;
    private void OnMouseEnter()
    {
        move = true;
    }
    private void OnMouseExit()
    {
        move = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (move)
        {
            Camera.main.transform.position += new Vector3(movementDir * movementSpeed * Time.deltaTime, 0);
            Camera.main.transform.position = new Vector3(Mathf.Clamp(Camera.main.transform.position.x, -2.3f, 2.3f), 0, -10);
        }
    }
    private void OnDisable()
    {
        move = false;
    }
}
