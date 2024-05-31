using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;


public class levelLoader : MonoBehaviour
{
    [SerializeField] private GameObject loadingScrean;
    [SerializeField] private GameObject uiobject;
    [Header("slider")]
    [SerializeField] public Slider uislider;
    [SerializeField] private TextMeshProUGUI text;
    public Animator transition;

    public void LoadScene(int sceneIndex)
    {
        uiobject.SetActive(false);
        loadingScrean.SetActive(true);

        StartCoroutine(LoadAsync(sceneIndex));
    }
    IEnumerator LoadAsync(int sceneIndex)
    {
        transition.SetTrigger("start");
        //     yield return new WaitForSeconds(1f);
        //     SceneManager.LoadScene(level);
        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneIndex);
        while (!operation.isDone)
        {
            float progress = Mathf.Clamp01(operation.progress / .9f);
            uislider.value = progress;
            text.text = progress * 100 + "%";
            yield return null;
        }
    }
    public void Loadlevel1()
    {
        LoadScene(1);
    }
    public void Loadlevel2()
    {
        LoadScene(4);
    }
    // public void LoadStartMenu()
    // {
    //     StartCoroutine(Loadlevel("inStart"));
    // }

    // public void Loadlevel1Op1()
    // {
    //     StartCoroutine(Loadlevel("option-1"));
    // }
    // public void Loadlevel1Op2()
    // {
    //     StartCoroutine(Loadlevel("option-2"));
    // }
}
