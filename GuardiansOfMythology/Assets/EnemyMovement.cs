using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    private Rigidbody2D m_Rb;
    private float m_Movespeed = 2f;


    private Transform m_Target;
    private int m_PathIndex = 1;


    private void Start()
    {
        m_Target = Waypoints.path[m_PathIndex];
    }

    private void Update()
    {
        Vector2 direction = m_Target.position - transform.position;
        transform.Translate(direction.normalized * (m_Movespeed * Time.deltaTime));

        if (Vector2.Distance(m_Target.position, transform.position) <= 0.1f)
        {
            m_PathIndex++;
        }

        if (m_PathIndex == Waypoints.path.Length)
        {
            Destroy(gameObject);
            return;
        }
        else
        {
            m_Target = Waypoints.path[m_PathIndex];

        }
    }
}
