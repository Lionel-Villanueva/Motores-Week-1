using UnityEngine;

public class PROBANDO : MonoBehaviour
{
    public LayerMask enemyLayer;

    void Start()
    {
        
    }

    void Update()
    {
        Ray ray = new Ray(transform.position, transform.forward);

        if (Physics.Raycast(ray, out RaycastHit hit, 100f, enemyLayer))
        {
            Debug.Log("Enemy Detected");
        }
    }

    void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawWireSphere(transform.position, 5f);
        Gizmos.color = Color.blue;
        
    }
}
