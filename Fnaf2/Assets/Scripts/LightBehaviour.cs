using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightBehaviour : MonoBehaviour
{
    public static int inputValue;
    public SpriteRenderer background;
    public Sprite officeOn, officeOff;
    public Sprite cameraOn, cameraOff;
    public static bool isOn;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (inputValue > 550)
            isOn = true;
        else
            isOn = false;
        if (isOn)
            background.sprite = MonitorSwitch.monitor ? CamerasManager.main.locations[CamerasManager.current].lightOn : officeOn;
        else
            background.sprite = MonitorSwitch.monitor ? CamerasManager.main.locations[CamerasManager.current].lightOff : officeOff;
    }
}
