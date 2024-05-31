using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
public class NewBehaviourScript : MonoBehaviour
{
    private VisualElement infoSign;
    private VisualElement infoDetails;


    // Start is called before the first frame update
    void Start()
    {
        var root = GetComponent<UIDocument>().rootVisualElement;
        infoSign = root.Q<VisualElement>("infoicon");
        infoDetails = root.Q<VisualElement>("infoDetails");
        infoDetails.style.display = DisplayStyle.None;
        infoDetails.style.opacity = 0;
        infoSign.RegisterCallback<MouseEnterEvent>(showDetails);
        infoSign.RegisterCallback<MouseLeaveEvent>(hideDetails);
    }
    public void showDetails(MouseEnterEvent evt)
    {
        infoDetails.style.display = DisplayStyle.Flex;
        infoDetails.style.opacity = 1;
    }
    public void hideDetails(MouseLeaveEvent evt)
    {
        infoDetails.style.display = DisplayStyle.None;
        infoDetails.style.opacity = 0;
    }
}
