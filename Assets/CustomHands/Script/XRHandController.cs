using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public enum HandType
{
    Left, Right
}

public class XRHandController : MonoBehaviour
{
    public HandType handType;

    public Animator animator;
    private static InputDevice inputDevice;

    public float _aim;
    public float _grip;
    public bool _primaryButtonValue;
    public bool _secondaryButtonValue;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        inputDevice = GetInputDevice();
    }

    // Update is called once per frame
    void Update()
    {
        AnimateHand();
    }

    InputDevice GetInputDevice()
    {
        InputDeviceCharacteristics controllerCharacteristics = InputDeviceCharacteristics.HeldInHand | InputDeviceCharacteristics.Controller;
        if (handType == HandType.Left)
        {
            controllerCharacteristics = controllerCharacteristics | InputDeviceCharacteristics.Left;
        }
        else
        {
            controllerCharacteristics = controllerCharacteristics | InputDeviceCharacteristics.Right;
        }
        List<InputDevice> inputDevices = new List<InputDevice>();
        InputDevices.GetDevicesWithCharacteristics(controllerCharacteristics, inputDevices);

        return inputDevices[0];
    }
    void AnimateHand()
    {
        inputDevice.TryGetFeatureValue(CommonUsages.trigger, out _aim);
        inputDevice.TryGetFeatureValue(CommonUsages.grip, out _grip);
        inputDevice.TryGetFeatureValue(CommonUsages.primaryButton, out _primaryButtonValue);
        inputDevice.TryGetFeatureValue(CommonUsages.secondaryButton, out _secondaryButtonValue);

        animator.SetFloat("Trigger", _aim);
        animator.SetFloat("Grip", _grip);
    }
}
