using UnityEngine;
using System.Collections;

public class GradeScript : MonoBehaviour
{
	[SerializeField]	
	private GameObject outraGrade;

    [SerializeField]
    private AudioSource audio;

	void OnTriggerStay2D(Collider2D col)
    {
        if(col.tag == "PrisioneiroAmigo")
        {
            audio.Play();
            Destroy(this.gameObject);
			Destroy(outraGrade);
        }
    }
}
