using UnityEngine;

public class IgnoreCharacterCollision : MonoBehaviour
{
    Transform character;

    void Awake()
    {
        character = GameObject.FindGameObjectWithTag("Player").transform;
    }

    public void IgnoreCollision()
    {
        Physics.IgnoreCollision(character.GetComponent<CharacterController>(), GetComponent<Collider>());
    }

    public void ActivateCollision()
    {
        Physics.IgnoreCollision(character.GetComponent<CharacterController>(), GetComponent<Collider>(), false);
    }
}
