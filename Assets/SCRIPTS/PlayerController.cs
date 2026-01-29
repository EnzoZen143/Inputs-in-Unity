using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f;
    public GameObject objectToSpawn;

    void Update()
    {
        float x = 0f;
        float y = 0f;

        if (Keyboard.current.wKey.isPressed)
            y = 1f;

        if (Keyboard.current.sKey.isPressed)
            y = -1f;

        if (Keyboard.current.aKey.isPressed)
            x = -1f;

        if (Keyboard.current.dKey.isPressed)
            x = 1f;

        Vector3 move = new Vector3(x, y, 0);
        transform.Translate(move * speed * Time.deltaTime);

        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            Instantiate(objectToSpawn, transform.position, Quaternion.identity);
        }
    }
}
