using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenFromInventoryPanel : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField ]Canvas partyCanvas;

    public void OpenPartyScreen()
    {
        partyCanvas.renderMode = RenderMode.WorldSpace;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
