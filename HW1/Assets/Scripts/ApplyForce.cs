using UnityEngine;

public class ApplyForce : MonoBehaviour
{
    public Rigidbody rb; 
    public Vector3 forceDirection = new Vector3(0, 0, 10f); 
    public float forceAmount = 5f; 

    void FixedUpdate() 
    {
        if (rb != null)
        {
            Debug.Log("Applying force to " + rb.gameObject.name);
            Debug.Log("Force direction normalized: " + forceDirection.normalized);
            rb.AddForce(forceDirection.normalized * forceAmount, ForceMode.Force);
        }
        else
        {
            Debug.LogError("Rigidbody is not assigned");
        }
    }
}
