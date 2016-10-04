using UnityEngine;
using System.Collections;

public class EnemyCameraBehaviour : MonoBehaviour
{
    [SerializeField]
    private float speed;
    Vector3 sumAngle =  new Vector3(0f, 0f, -0.5f);
	void Update ()
    {
        this.transform.eulerAngles += sumAngle * Time.deltaTime * speed;
        if(this.transform.eulerAngles.z <= 310)
        {
            sumAngle = new Vector3(0f, 0f, 0.5f);
        }
        else if(this.transform.eulerAngles.z >= 359)
        {
            sumAngle = new Vector3(0f, 0f, -0.5f);
        }
	}
}
