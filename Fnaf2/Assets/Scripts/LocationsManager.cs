using System.Collections;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using UnityEngine;

public class LocationsManager : MonoBehaviour
{
    public Location[] locations = new Location[12];
    public static LocationsManager main;

    // Start is called before the first frame update
    void Awake()
    {
        main = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void MoveAnimatronic(int index, int from, int to)
    {
        locations[from].indexHere.Remove(index);
        locations[to].indexHere.Add(index);

        string onPath = locations[from].name + "/";
        string offPath = locations[from].name + "/";
        for (int i = 0; i < locations[from].animatronics.Length; i++)
        {
            
        }
        CamerasManager.main.locations[from].lightOn = Resources.Load<Sprite>(onPath + "On");
        CamerasManager.main.locations[from].lightOff = Resources.Load<Sprite>(offPath + "Off");

        onPath = locations[to].name + "/";
        offPath = locations[to].name + "/";
        for (int i = 0; i < locations[to].animatronics.Length; i++)
        {

        }
        CamerasManager.main.locations[to].lightOn = Resources.Load<Sprite>(onPath + "On");
        CamerasManager.main.locations[to].lightOff = Resources.Load<Sprite>(offPath + "Off");
    }
}
[System.Serializable]
public class Location
{
    public string name;
    public bool oneAnimatronic;
    public int[] alwaysVisible;
    public int[] invisible;
    public int[] animatronics;
    public List<int> indexHere = new List<int>();
}
