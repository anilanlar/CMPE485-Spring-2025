using UnityEngine;

public class MoveObject : MonoBehaviour
{
    public float speed = 5f;

    void Update()
    {
        float moveX = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        float moveZ = Input.GetAxis("Vertical") * speed * Time.deltaTime;

        transform.Translate(moveX, 0, moveZ);
    }

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Object " + gameObject.name + " collided with: " + collision.gameObject.name);
    }
}
