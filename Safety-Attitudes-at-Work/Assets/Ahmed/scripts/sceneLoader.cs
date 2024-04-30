using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class sceneLoader : MonoBehaviour
{
    public Animator transition;
    public void LoadStartMenu()
    {
        StartCoroutine(Loadlevel("inStart"));
    }
    public void Loadlevel1()
    {
        StartCoroutine(Loadlevel("main scene"));
    }
    public void Loadlevel1Op1()
    {
        StartCoroutine(Loadlevel("L1-S1"));
    }
    public void Loadlevel1Op2()
    {
        StartCoroutine(Loadlevel("L1-O2"));
    }

    IEnumerator Loadlevel(string level)
    {
        transition.SetTrigger("start");
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene(level);
    }
}
