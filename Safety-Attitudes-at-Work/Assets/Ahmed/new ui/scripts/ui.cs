using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UIElements;


public class ui : MonoBehaviour
{

    private VisualElement mainmenu;
    private VisualElement details1;
    private VisualElement details2;

    private SliderInt volumeSlider;

    private Button level1;
    private Button level2;
    private Button newgamebtn;
    private Button videosbtn;
    private Button optionsbtn;
    private Button closeLoadMenu;
    private Button closeOptions;
    private Button exit;

    private VisualElement optionsMenu;
    [SerializeField] private GameObject videosmenu;
    [SerializeField] private GameObject uidoc;
    [SerializeField] public GameObject themee;
    private VisualElement loadMenu;
    private levelLoader levelLoader;
    public Animator transition;
    public AudioMixer audioMixer;



    // Start is called before the first frame update
    void Start()
    {
        levelLoader = GameObject.Find("sceneLoader").GetComponent<levelLoader>();
        var root = GetComponent<UIDocument>().rootVisualElement;

        mainmenu = root.Q<VisualElement>("mainmenu");
        optionsMenu = root.Q<VisualElement>("optionsMenu");
        details1 = root.Q<VisualElement>("details1");
        details2 = root.Q<VisualElement>("details2");

        level1 = root.Q<Button>("level-1");

        level2 = root.Q<Button>("level-2");
        newgamebtn = root.Q<Button>("newgamebtn");

        videosbtn = root.Q<Button>("videosbtn");

        optionsbtn = root.Q<Button>("optionsbtn");

        closeLoadMenu = root.Q<Button>("closeLoadMenu");

        closeOptions = root.Q<Button>("closeOptions");

        loadMenu = root.Q<VisualElement>("LoadgameMenu");

        exit = root.Q<Button>("exit");

        details1.style.opacity = 0;
        details2.style.opacity = 0;


        loadMenu.style.display = DisplayStyle.None;
        loadMenu.style.opacity = 0;
        optionsMenu.style.display = DisplayStyle.None;
        level1.RegisterCallback<MouseEnterEvent>(showDetails1);
        level1.RegisterCallback<ClickEvent>(clickLoadlevel1);
        level1.RegisterCallback<MouseLeaveEvent>(hideDetails1);
        level2.RegisterCallback<MouseEnterEvent>(showDetails2);
        level2.RegisterCallback<ClickEvent>(clickLoadlevel2);
        level2.RegisterCallback<MouseLeaveEvent>(hideDetails2);

        newgamebtn.RegisterCallback<ClickEvent>(openLoadMenu);
        videosbtn.RegisterCallback<ClickEvent>(openvideosmenu);
        optionsbtn.RegisterCallback<ClickEvent>(openOptionsMenu);
        closeOptions.RegisterCallback<ClickEvent>(closeOptionsMenu);
        closeLoadMenu.RegisterCallback<ClickEvent>(closeLoadMenufunc);
        exit.RegisterCallback<ClickEvent>(exitgame);
    }
    void Update()
    {
        if (videosmenu.active == false)
        {
            mainmenu.style.display = DisplayStyle.Flex;
        }

    }
    // Update is called once per frame
    private void showDetails1(MouseEnterEvent evt)
    {
        details1.style.opacity = 1;
    }
    private void hideDetails1(MouseLeaveEvent evt)
    {
        details1.style.opacity = 0;
    }
    private void showDetails2(MouseEnterEvent evt)
    {
        details2.style.opacity = 1;
    }
    private void hideDetails2(MouseLeaveEvent evt)
    {
        details2.style.opacity = 0;
    }
    private void openLoadMenu(ClickEvent evt)
    {
        loadMenu.style.display = DisplayStyle.Flex;
        loadMenu.style.opacity = 1;
    }
    private void closeLoadMenufunc(ClickEvent evt)
    {
        loadMenu.style.display = DisplayStyle.None;
    }
    private void clickLoadlevel1(ClickEvent evt)
    {
        transition.SetTrigger("start");
        levelLoader.Loadlevel1();
    }
    private void clickLoadlevel2(ClickEvent evt)
    {
        transition.SetTrigger("start");
        levelLoader.Loadlevel2();
    }
    private void openvideosmenu(ClickEvent evt)
    {
        videosmenu.SetActive(true);
        mainmenu.style.display = DisplayStyle.None;
        themee.SetActive(false);
    }
    public void openOptionsMenu(ClickEvent evt)
    {
        optionsMenu.style.display = DisplayStyle.Flex;
    }
    public void closeOptionsMenu(ClickEvent evt)
    {
        optionsMenu.style.display = DisplayStyle.None;
    }
    public void exitgame(ClickEvent evt)
    {
        Application.Quit();
    }
}
