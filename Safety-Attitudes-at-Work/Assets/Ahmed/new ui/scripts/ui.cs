using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;


public class ui : MonoBehaviour
{

    private VisualElement mainmenu;
    private VisualElement details;
    private Button level1;
    private Button newgamebtn;
    private Button videosbtn;
    private Button closeLoadMenu;

    [SerializeField] private GameObject videosmenu;
    [SerializeField] private GameObject uidoc;
    [SerializeField] public GameObject themee;
    private VisualElement loadMenu;
    private levelLoader levelLoader;
    public Animator transition;

    // Start is called before the first frame update
    void Start()
    {
        levelLoader = GameObject.Find("sceneLoader").GetComponent<levelLoader>();
        var root = GetComponent<UIDocument>().rootVisualElement;

        mainmenu = root.Q<VisualElement>("mainmenu");

        details = root.Q<VisualElement>("details");

        level1 = root.Q<Button>("level-1");


        newgamebtn = root.Q<Button>("newgamebtn");

        videosbtn = root.Q<Button>("videosbtn");

        closeLoadMenu = root.Q<Button>("closeLoadMenu");

        loadMenu = root.Q<VisualElement>("LoadgameMenu");

        details.style.opacity = 0;


        loadMenu.style.display = DisplayStyle.None;
        loadMenu.style.opacity = 0;

        level1.RegisterCallback<MouseEnterEvent>(showDetails);
        level1.RegisterCallback<ClickEvent>(clickLoadlevel1);

        level1.RegisterCallback<MouseLeaveEvent>(hideDetails);

        newgamebtn.RegisterCallback<ClickEvent>(openLoadMenu);
        videosbtn.RegisterCallback<ClickEvent>(openvideosmenu);

        closeLoadMenu.RegisterCallback<ClickEvent>(closeLoadMenufunc);
    }
    void Update()
    {
        if (videosmenu.active == false)
        {
            mainmenu.style.display = DisplayStyle.Flex;
        }

    }
    // Update is called once per frame
    private void showDetails(MouseEnterEvent evt)
    {
        details.style.opacity = 1;
    }
    private void hideDetails(MouseLeaveEvent evt)
    {
        details.style.opacity = 0;
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
    private void openvideosmenu(ClickEvent evt)
    {
        videosmenu.SetActive(true);
        mainmenu.style.display = DisplayStyle.None;
        themee.SetActive(false);
    }

}
