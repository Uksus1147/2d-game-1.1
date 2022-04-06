using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class EndGame : MonoBehaviour
{
    public GameObject Winner;
    public GameObject looser;

    public void Start()
    {
        Time.timeScale = 1;
    }
    //void Update()
    //{
    //    if (DioHealth <= 0)
    //    {
    //        Time.timeScale = 0;
    //        looser.SetActive(true);
    //    }
    //    else if (JotaroHealth <= 0)
    //    {
    //        Time.timeScale = 0;
    //        Winner.SetActive(true);
    //    }
    //}
    public void JotaroWin(bool lose)
    {
        if (lose == true)
        {
            Time.timeScale = 0;
            looser.SetActive(true);
        }
    }
    public void DioWin(bool win)
    {
        if (win == true)
        {
            Time.timeScale = 0;
            Winner.SetActive(true);
        }
    }
    public void Restart(int SceneNumber)
    {
        SceneManager.LoadScene(SceneNumber);
    }
}
