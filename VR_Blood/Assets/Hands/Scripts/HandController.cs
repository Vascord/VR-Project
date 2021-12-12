using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class HandController : MonoBehaviour
{
    ActionBasedController abController;
    Hand hand;

    void Awake()
    {
        abController = GetComponent<ActionBasedController>();
        hand = GetComponentInChildren<Hand>();
    }

    void Update()
    {
        hand.SetGrip(abController.selectAction.action.ReadValue<float>());
        hand.SetTrigger(abController.activateAction.action.ReadValue<float>());
    }
}
