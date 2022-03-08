using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CloseCanvas : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] public Button closeButton;
    [SerializeField]
    public Canvas closingCanvas
        ;

    void Start()
    {
        Button btn = closeButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }
    void TaskOnClick()
    {
        closingCanvas.renderMode = RenderMode.WorldSpace;
        closingCanvas.transform.position = new Vector3(999, 999, 999);
    }
}
