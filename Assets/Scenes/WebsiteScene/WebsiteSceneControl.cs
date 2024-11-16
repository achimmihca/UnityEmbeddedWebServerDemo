using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class WebsiteSceneControl : MonoBehaviour
{
    public Button button;
    public TMP_Text label;
    private int clickCount;

    private void Start()
    {
        button.onClick.AddListener(OnButtonClick);
    }

    private void OnDestroy()
    {
        button.onClick.RemoveListener(OnButtonClick);
    }

    private void OnButtonClick()
    {
        clickCount++;
        label.text = "Clicks: " + clickCount;
    }
}
