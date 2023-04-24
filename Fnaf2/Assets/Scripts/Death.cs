using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Death : MonoBehaviour
{

    public void DeathScreen()
    {
        SceneManager.LoadScene(1);
    }
}
