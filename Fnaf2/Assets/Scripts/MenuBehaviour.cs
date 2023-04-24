using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuBehaviour : MonoBehaviour
{
    public Animator background;
    public string[] animationNames;

    float timer;
    float waitTime = 3f;

    private void Update()
    {
        if (timer > waitTime)
        {
            PlayRandomAnimation();
            timer = 0;
        }
        else
            timer += Time.deltaTime;
    }


    public void PlayRandomAnimation()
    {
        waitTime = Random.Range(0.5f, 1.5f);
        background.Play(animationNames[Random.Range(0, animationNames.Length)]);
    }

    public void SwitchScene(int index)
    {
        SceneManager.LoadScene(index);
    }
}
