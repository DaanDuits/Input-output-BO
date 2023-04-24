using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatronicsManager : MonoBehaviour
{
    public Animatronic[] animatronics = new Animatronic[10];
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        foreach (Animatronic a in animatronics)
        {

        }
    }
}
[System.Serializable]
public class Animatronic
{
    public string name;
    public int currentLocation;
    public bool invisible;
    public bool alwaysVisible;
    public bool sometimesVisible;
    public Path route;
}

[System.Serializable]
public class Path
{
    public MovementSpot[] locations;
    public IntList[] constraints;
    public IntList[] waitFor;
}

[System.Serializable]
public class MovementSpot
{
    public int location;
    public bool canGoBack;
}

[System.Serializable]
public class IntList
{
    public int[] constraints;
}
