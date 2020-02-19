using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;


public class Player : MonoBehaviour {
    private Rigidbody2D playerRb;
    private SpriteRenderer playerSprite;
    public float velocidade;
    public bool flipX;
    private const string ButtonName = "space";
    private const string NameButton = "x";

    // Use this for initialization
    void Start () {
        playerRb = GetComponent<Rigidbody2D>();
        playerSprite = GetComponent<SpriteRenderer>();
	}
	
	// Update is called once per frame
	void Update () {

        //OBS (Jogo): Mapa Não está alinhada visualmente com a camera(Game/Scene)
        //Box colider espinhoParede Não estão colidindo, por causa da camera !

        if (Input.GetButtonDown(buttonName: ButtonName))
        {
            velocidade *= -1;
            flipX = !flipX;
            playerSprite.flipX = flipX;
        }

        /* Fazer um botão para acelerar o Player 
       
        if (Input.GetButtonDown(buttonName: NameButton))
        {
            velocidade *= 2;
            playerSprite.flipX = flipX;

        }
        */
        playerRb.velocity = new Vector2(velocidade, playerRb.velocity.y);
	}

    private void OnCollisionEnter2D(Collision2D colisao)
    {
        if (colisao.gameObject.tag == "espinho")
        {
            SceneManager.LoadScene("gameover");
        }
    }

    private void OnTriggerEnter2D(Collider2D colisao)
    {
        if (colisao.gameObject.tag == "espinho")
        {
            SceneManager.LoadScene("gameover");
        }
    }

    //OBS: Espinhos teto Não estão enviando a mensagem do print !
}
