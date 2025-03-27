using UnityEngine;

public class TvBehaviour : MonoBehaviour
{
    public Material tvMat;
    public Material tvOn;
    public Material tvOff;
    [SerializeField]
    private bool isOn;
    private MeshRenderer renderer;

    private void Awake()
    {
        renderer = GetComponent<MeshRenderer>();
    }

    public void TurnTvOn()
    {
        if (renderer is null)
        {
            return;
        }
        Material[] materials = renderer.materials; 
        materials[materials.Length - 1] = tvOn; 
        renderer.materials = materials; 
    }

    public void TurnTvOff()
    {
        if (renderer is null)
        {
            return;
        }
        Material[] materials = renderer.materials;
        materials[materials.Length - 1] = tvOff;
        renderer.materials = materials;
    }
}
