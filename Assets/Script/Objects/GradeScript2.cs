using UnityEngine;
using System.Collections;

public class GradeScript2 : MonoBehaviour
{
    [SerializeField] private GameObject player;
    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.tag == "Player" && player.GetComponent<PlayerBehaviour>().holdingKey)
        {
            Destroy(this.gameObject);
        }
    }    	
}
