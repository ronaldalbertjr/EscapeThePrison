using UnityEngine;
using System.Collections;

public class GradeScript : MonoBehaviour
{
	[SerializeField]	
	private GameObject outraGrade;

	void OnTriggerStay2D(Collider2D col)
    {
        if(col.tag == "Player" && Input.GetKey(KeyCode.Return))
        {
            Destroy(this.gameObject);
			Destroy(outraGrade);
        }
    }
}
