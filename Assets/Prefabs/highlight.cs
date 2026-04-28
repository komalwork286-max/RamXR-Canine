using UnityEngine;

public class Highlight : MonoBehaviour
{
    private Material originalMaterial;
    public Material highlightMaterial;
    private Renderer rend;

    void Awake()
    {
        rend = GetComponent<Renderer>();
        originalMaterial = rend.material;
    }

    public void OnHoverEnter()
    {
        rend.material = highlightMaterial;
    }

    public void OnHoverExit()
    {
        rend.material = originalMaterial;
    }
}