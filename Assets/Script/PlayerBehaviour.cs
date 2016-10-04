using UnityEngine;
using System.Collections;

public class PlayerBehaviour : MonoBehaviour
{
    public float speed;
	public float moreSpeedFloat;
	[HideInInspector] public bool wearingBoots, holdingKey, enemy1DontFollow, wearingNormal, wearingCopClothes, gotCopClothes;
	public RuntimeAnimatorController animController, animBootsController, animNormal;
	public GameObject hudImage;
    float movementHorizontal;
    float movementVertical;
    Vector3 mousePosition;
    Vector3 lookPosition;
	Quaternion rotation;
	[SerializeField] private AudioSource audio;

	void Start()
	{
        audio.Pause();
		wearingBoots = false;
		wearingCopClothes = false;
		gotCopClothes = false;
		wearingNormal = true;
	}

	void Update()
    {
        if (wearingNormal)
            normalClothes();
        if (!wearingNormal)
            copClothes();
        if (gotCopClothes)
        {
            if (Input.GetKeyDown(KeyCode.LeftShift))
                wearingNormal = !wearingNormal;
        }
        ///Fazer o personagem rotacionar e mudar sua visão
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            this.transform.rotation = Quaternion.Euler(0f, 0f, 90f);
        }
        else if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            this.transform.rotation = Quaternion.Euler(0f, 0f, 180f);
        }
        else if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            this.transform.rotation = Quaternion.Euler(0f, 0f, 270f);
        }
        else if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            this.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
        }

		if (Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.LeftArrow) && Input.GetKey(KeyCode.UpArrow))
			this.transform.rotation = Quaternion.Euler(0f, 0f, 45f);
		if (Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.LeftArrow) && Input.GetKey(KeyCode.DownArrow))
			this.transform.rotation = Quaternion.Euler(0f, 0f, 135f);
		if (Input.GetKey(KeyCode.D) && Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.RightArrow) && Input.GetKey(KeyCode.UpArrow))
			this.transform.rotation = Quaternion.Euler(0f, 0f, 315f);
		if (Input.GetKey(KeyCode.D) && Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.RightArrow) && Input.GetKey(KeyCode.DownArrow))
			this.transform.rotation = Quaternion.Euler(0f, 0f, 225f);

        if (movementHorizontal != 0 || movementVertical != 0)
        {
			audio.UnPause();
            this.GetComponent<Animator>().SetBool("IsWalking", true);
        }
        else
        {
			audio.Pause();
            this.GetComponent<Animator>().SetBool("IsWalking", false);
        }
    }

	void FixedUpdate ()
    {
        //Movimenta o personagem nas 8 direcões
        movementHorizontal = Input.GetAxis("Horizontal");
        movementVertical = Input.GetAxis("Vertical");
		if(!wearingBoots)
		{
			this.GetComponent<Rigidbody2D>().velocity = new Vector2(movementHorizontal * speed, movementVertical * speed); 
		}
		else if(wearingBoots)
		{
			this.GetComponent<Rigidbody2D>().velocity = new Vector2(movementHorizontal * moreSpeedFloat, movementVertical * moreSpeedFloat); 
		}
	}

	//trocar o animator para o de roupa de policial
    public void copClothes()
    {
		this.GetComponent<Animator>().runtimeAnimatorController = animController;
		wearingCopClothes = true;
		wearingNormal = false;
	}
	
	//trocar o animator para o de roupa de dentento com ou sem bota
	public void normalClothes()
	{
		if(wearingBoots)
		{
			this.GetComponent<Animator>().runtimeAnimatorController = animBootsController;
		}
		else if(!wearingBoots)
		{
			this.GetComponent<Animator>().runtimeAnimatorController = animNormal;
		}
		wearingCopClothes = false;
		wearingNormal = true;
	}
	
	void OnTriggerStay2D(Collider2D col)
	{
		//verificar pra trocar HUD e nao deixar ou deixar o policial 1 seguir
		if(col.tag == "Serio")
		{
			hudImage.GetComponent<Animator>().SetBool("serio", true);
			hudImage.GetComponent<Animator>().SetBool("medo", false);
			hudImage.GetComponent<Animator>().SetBool("ironico", false);
			enemy1DontFollow = true;
		}
		else if(col.tag == "Medo")
		{
			hudImage.GetComponent<Animator>().SetBool("serio", false);
			hudImage.GetComponent<Animator>().SetBool("medo", true);
			hudImage.GetComponent<Animator>().SetBool("ironico", false);
			enemy1DontFollow = false;
		}
		else if(col.tag == "Ironico")
		{
			hudImage.GetComponent<Animator>().SetBool("serio", false);
			hudImage.GetComponent<Animator>().SetBool("medo", false);
			hudImage.GetComponent<Animator>().SetBool("ironico", true);
			enemy1DontFollow = false;
		}
	}
}
