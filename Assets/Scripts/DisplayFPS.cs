using UnityEngine;

public class DisplayFPS : MonoBehaviour
{
    public float fps;
    public TMPro.TextMeshProUGUI FPS_Counter_Text;

    private void Start()
    {
        InvokeRepeating("GetFPS", 1, 1);
    }

    void GetFPS()
    {
        fps = (int)(1f / Time.unscaledDeltaTime);
        FPS_Counter_Text.text = "FPS: " + fps.ToString();
    }
}
