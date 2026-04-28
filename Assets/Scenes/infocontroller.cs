using UnityEngine;
using TMPro;

public class InfoController : MonoBehaviour
{
    public TextMeshProUGUI infoText;

    int index = 0;

    string[] data = {
        "The human skeleton has 206 bones.",
        "The skull protects the brain.",
        "The rib cage protects vital organs.",
        "The spine supports the body."
    };

    void Start()
    {
        infoText.text = data[index];
    }

    public void Next()
    {
        index = (index + 1) % data.Length;
        infoText.text = data[index];
    }

    public void Previous()
    {
        index = (index - 1 + data.Length) % data.Length;
        infoText.text = data[index];
    }
}