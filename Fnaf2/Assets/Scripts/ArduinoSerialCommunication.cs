using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO.Ports;
using System;
using TMPro;
using System.Linq;

public class ArduinoSerialCommunication : MonoBehaviour
{
    SerialPort Serial;
    public TMP_Dropdown dropdown;

    // Start is called before the first frame update
    void Start()
    {
        Serial = new SerialPort();

        Serial.BaudRate = 9600;
        Serial.PortName = PlayerPrefs.GetString("InputPort");
        Serial.Parity = Parity.None;
        Serial.DataBits = 8;
        Serial.StopBits = StopBits.One;

        Serial.Open();
    }
    // Update is called once per frame
    void Update()
    {
        if (Serial.BytesToRead > 0)
        {
            string line = Serial.ReadLine();
            string[] values = line.Split(' ');
            LightBehaviour.inputValue = int.Parse(values[1]);
            float val = int.Parse(values[0]);
            val /= 400;
            WindupBehaviour.speed = val;
            Debug.Log(line);
        }
    }
}
