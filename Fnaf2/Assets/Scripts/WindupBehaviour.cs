using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class WindupBehaviour : MonoBehaviour
{
    public static float speed;
    public float drainSpeed;
    public Slider slider;
    bool active;
    bool canPlay = true;

    public Animator marionette;
    public AudioSource sound;
    public void SetActive(bool b)
    {
        active = b;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (speed == 0)
            slider.value -= drainSpeed * Time.deltaTime;
        else if (MonitorSwitch.monitor && active)
            slider.value += speed * Time.deltaTime;
        if (!MonitorSwitch.monitor)
            slider.gameObject.SetActive(false);
        else
            slider.gameObject.SetActive(active);

        if (slider.value == 0 && canPlay)
        {
            marionette.Play("The Marionette");
            canPlay = false;
            sound.Play();
        }
    }
}
