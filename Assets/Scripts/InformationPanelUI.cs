using UnityEngine;
using TMPro;
using UnityEngine.XR.Interaction.Toolkit;

public class InformationPanelUI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI infoText;

    public void OnFocus(FocusEnterEventArgs args)
    {
        if (args.interactableObject == null)
        {
            infoText.text = "No Object";
            return;
        }

        // Get the GameObject name of the focused interactable
        var interactable = args.interactableObject.transform.gameObject;
        infoText.text = interactable.name;
    }
}