using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu_skr : MonoBehaviour
{
    public GameObject menu1;
    public GameObject nast;
    public void Pl()
    {
        SceneManager.LoadScene(1);
    }
    public void Pl1()
    {
        SceneManager.LoadScene(0);
    }
    public void nast0()
    {
        menu1.SetActive(false);
        nast.SetActive(true);
    }
    public void Exit()
    {
        Application.Quit();
    }
}
