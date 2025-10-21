using UnityEngine;

public class Flashlight : MonoBehaviour
{
    public Light flashlight; // arraste o Spot Light aqui
    public KeyCode toggleKey = KeyCode.F;
    private bool isOn = false;

    void Start()
    {
        if (flashlight != null)
            flashlight.enabled = false; // começa desligada
    }

    void Update()
    {
        if (Input.GetKeyDown(toggleKey))
        {
            isOn = !isOn;
            flashlight.enabled = isOn;
        }
    }
}
