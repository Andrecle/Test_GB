//using KinematicCharacterController;
using UnityEngine;

public class GateTrigger : MonoBehaviour
{
    [SerializeField] private Gate _gate;
    [SerializeField] private Rigidbody _FirstPersonController;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Rigidbody>().Equals(_FirstPersonController))
        {
            _gate.Toggle();
        }
    }
}
