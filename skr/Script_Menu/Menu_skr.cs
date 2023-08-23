using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu_skr : MonoBehaviour
{
    public GameObject menu1;
    public GameObject nast;
    public GameObject YesOrNo;
    public GameObject gamecomplite;
    private int N = -1;
    public void newGame()
    {
        menu1.SetActive(false);
        YesOrNo.SetActive(true);
    }
    public void newGameNo()
    {
        menu1.SetActive(true);
        YesOrNo.SetActive(false);
    }
    public void newGameYes()
    {
        
            N = 0;
            PlayerPrefs.SetInt("nightN", N);
            SceneManager.LoadScene(1);
        
    }
    public void Pl()
    {
        N = PlayerPrefs.GetInt("nightN");
        if (((N>=0) && (N<=5)))
        {
            SceneManager.LoadScene(1);
        }
        if ((N > 5)) 
        {
            gamecomplite.SetActive(true);
        }
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
