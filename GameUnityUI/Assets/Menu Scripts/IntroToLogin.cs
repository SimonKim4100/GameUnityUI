using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IntroToLogin : MonoBehaviour
{
    public float wait_time = 3.5f;
    void Start()
    {
        StartCoroutine(wait_intro());
    }

    IEnumerator wait_intro()
    {
        yield return new WaitForSeconds(wait_time);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}

