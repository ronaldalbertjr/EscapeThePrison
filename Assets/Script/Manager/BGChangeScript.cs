using UnityEngine;
using System.Collections;

public class BGChangeScript : MonoBehaviour
{
    [SerializeField]
    private GameObject[] prisioneiros;
    [SerializeField]
    private GameObject[] policiais;
    [SerializeField]
    private GameObject policial;
    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.tag == "Player")
        {
            policial.GetComponent<EnemyBehaviour>().followingPlayer = false;
            foreach(GameObject i in prisioneiros)
            {
                i.GetComponent<RebeldesBehaviour>().followingPlayer = false;
            }
            foreach(GameObject i in policiais)
            {
                i.GetComponent<EnemyBehaviour3>().followingPlayer = false;
            }
        }
    }
}
