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
            StartCoroutine(gradeMoving());
        }
    }
    IEnumerator gradeMoving()
    {
        audio.Play();
        for (int i = 0; i < 3; i++)
        {
            this.transform.position += new Vector3(0.1f, 0f);
            outraGrade.transform.position -= new Vector3(0.1f, 0f);
            yield return new WaitForSeconds(0.000001f);
        }

        yield return null;
    }
    
}
