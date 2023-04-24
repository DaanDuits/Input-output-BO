using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathScreenBehaviour : MonoBehaviour
{
    float timer = 0;
    public float waitTime;
    public SpriteRenderer staticSR;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(staticSR.color.a > 0.4f);
        if (timer > waitTime && staticSR.color.a > 0.4f)
            staticSR.color -= new Color(0, 0, 0, Time.deltaTime * 0.2f);
        else
            timer += Time.deltaTime;
        if (staticSR.color.a <= 0.4f && Input.GetMouseButtonDown(0))
            SceneManager.LoadScene(2);
    }
}
