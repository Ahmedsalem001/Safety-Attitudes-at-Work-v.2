using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class sceneLoader : MonoBehaviour
{
    public Animator transition;
    public void LoadStartMenu()
    {
        StartCoroutine(Loadlevel("newUI"));
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
    public void loadLevel2()
    {
        StartCoroutine(Loadlevel("L2-Main S"));
    }
    public void Loadlevel2Op1()
    {
        StartCoroutine(Loadlevel("L2-O1-S1"));
    }
    public void Loadlevel2Op1part2()
    {
        StartCoroutine(Loadlevel("L2-O1-S2"));
    }
    public void Loadlevel2Op1part3()
    {
        StartCoroutine(Loadlevel("L2-O1-S3"));
    }
    public void Loadlevel2Op2()
    {
        StartCoroutine(Loadlevel("L2-O2-S1"));
    }

    IEnumerator Loadlevel(string level)
    {
        transition.SetTrigger("start");
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene(level);
    }
}
