using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO.Ports;
using System;
using TMPro;
using System.Linq;

public class InputPortsDropdown : MonoBehaviour
{
    public TMP_Dropdown dropdown;

    // Start is called before the first frame update
    void Start()
    {
        string[] ports = SerialPort.GetPortNames();

        dropdown.AddOptions(ports.ToList());
    }

    public void SetPort()
    {
        PlayerPrefs.SetString("InputPort", dropdown.options[dropdown.value].text);
    }
}
