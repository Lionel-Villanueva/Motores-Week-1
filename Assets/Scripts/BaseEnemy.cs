using UnityEngine;

public class BaseEnemy : MonoBehaviour
{
    private float Range = 4f;
    private Transform playerTransform;



    void Start()
    {
        GetComponent<SphereCollider>().radius = Range;
    }

    void Update()
    {
        

    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            print("Player Detectado");
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            print("Player se fue");
        }
    }
    void OnDrawGizmos()
    {
        Gizmos.color = Color.purple;
        Gizmos.DrawWireSphere(transform.position, Range);

        if (playerTransform != null)
        {
            Gizmos.color = Color.yellow;
            Gizmos.DrawLine(transform.position, playerTransform.position);

        }

    }
}
