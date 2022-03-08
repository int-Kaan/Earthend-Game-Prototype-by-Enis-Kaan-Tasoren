using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenPartyScreen : MonoBehaviour
{
    [SerializeField] Button b1;
    [SerializeField] Canvas partyCanvas;

    void Start()
    {
        Button btn = b1.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }
    void TaskOnClick()
    {
        partyCanvas.renderMode = RenderMode.ScreenSpaceOverlay;
    }
}
