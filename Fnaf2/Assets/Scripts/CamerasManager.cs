using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CamerasManager : MonoBehaviour
{
    public SpriteRenderer background;
    public Image nameDisplay;
    public Location[] locations = new Location[12];
    public static int current = 8;
    public static CamerasManager main;

    public void SwitchCam(int index)
    {
        current = index;
        nameDisplay.sprite = locations[current].name;

        background.transform.localScale = locations[current].scale;
    }

    // Start is called before the first frame update
    void Start()
    {
        main = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    [System.Serializable]
    public struct Location
    {
        public Sprite lightOn;
        public Sprite lightOff;
        public Sprite name;
        public Vector3 scale;
    }
}
