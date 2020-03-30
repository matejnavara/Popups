using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleManager : MonoBehaviour
{
    public GameObject creditsObj;

    private bool inCredits = false;

    void Start()
    {
        creditsObj.SetActive(false);
    }

    public void ToggleCredits()
    {
        inCredits = !inCredits;
        creditsObj.SetActive(inCredits);
    }

    public void Play()
    {
        SceneManager.LoadScene(1);
    }
}
