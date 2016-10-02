using UnityEngine;
using System.Collections;

public class BGDeathRallScript : MonoBehaviour 
{
	public Transform mainCamera;
	private float shakeDuration;
	private float shakeAmount;
	private float decreaseFactor;
	private Vector3 camPosition;
	private bool canShock;

	void Start ()
	{
		canShock = true;
		mainCamera = Camera.main.transform;
		shakeDuration = 0;
		shakeAmount = 0.7f;
		decreaseFactor = 1;
	}

	void Update()
	{
		camPosition = mainCamera.position;
		if (shakeDuration > 0)
		{
			mainCamera.localPosition = camPosition + Random.insideUnitSphere * shakeAmount;
			shakeDuration -= Time.deltaTime * decreaseFactor;
		}
		else
		{
			shakeDuration = 0f;
			mainCamera.localPosition = camPosition;
		}
	}

	void OnTriggerStay2D(Collider2D col)
	{
		shakeDuration = 0.1f;
	}

	void OnTriggerExit2D(Collider2D col)
    {
        Debug.Log("Venceu");
    }
}
