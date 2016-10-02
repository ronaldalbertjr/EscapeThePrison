using UnityEngine;
using System.Collections;

public class BGScript : MonoBehaviour
{
    public GameObject cam;
    public Transform camPosition;
    bool lerping = false;
	private float activeZoom;

	void Update()
	{
		activeZoom = Time.time;
	}

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag == "Player")
        {
            //Mudando a posicão da camera de acordo com as cenas
            cam.transform.position = Vector3.Lerp(this.transform.position, camPosition.position, 0.1f);
        }
		if(this.gameObject.name == "DeathRallBG" && col.gameObject.tag == "Player")
		{
			Camera.main.orthographicSize = Mathf.Lerp (5, 3, 3f * (Time.time - activeZoom));
		}
    }
}
