using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class MonitorSwitch : MonoBehaviour, IPointerEnterHandler
{
    public  SpriteRenderer background;
    public Sprite offis;
    public Animator animator;
    public string close, open;
    public static bool monitor;
    public Vector3 officeScale;

    public RectTransform rtransform;
    public Image image;
    public GameObject[] office;
    public GameObject[] camera;

    Vector3 headPosition;

    public ButtonMode inMonitor, inOffice;
    ButtonMode currentMode;

    public void OnPointerEnter(PointerEventData eventData)
    {
        animator.Play(monitor ? close : open);
        monitor = !monitor;
        SwitchState();
    }

    public void SwitchState()
    {
        if (monitor)
        {
            headPosition = Camera.main.transform.position;
            Camera.main.transform.position = new Vector3(0, 0, -10);
            background.transform.localScale = CamerasManager.main.locations[CamerasManager.current].scale;
        }
        else
        {
            Camera.main.transform.position = headPosition;
            background.transform.localScale = officeScale;
        }

        for (int i = 0; i < office.Length; i++)
        {
            office[i].SetActive(!monitor);
        }
        for (int i = 0; i < camera.Length; i++)
        {
            camera[i].SetActive(monitor);
        }
        currentMode = monitor ? inMonitor : inOffice;

        background.sprite = monitor ? CamerasManager.main.locations[CamerasManager.current].lightOff : offis;

        image.sprite = currentMode.sprite;
        image.color = currentMode.color;
        rtransform.anchoredPosition = currentMode.position;
        rtransform.sizeDelta = currentMode.scale;
    }

    [System.Serializable]
    public struct ButtonMode
    {
        public Color color;
        public Sprite sprite;
        public Vector3 scale, position;
    }
}
