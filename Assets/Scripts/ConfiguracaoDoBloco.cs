using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConfiguracaoDoBloco : MonoBehaviour
{
    // Coloquei o som do bloco no GameManager
    // public GameObject somBloco;

    // Start is called before the first frame update
    void Start()
    {
        FindObjectOfType<GameManager>().AdicionarBloco();
    }

    // Update is called once per frame
    void Update()
    {

    }

    // A variavel collison que o m�todo recebe s�o os outros game objects da cena
    // Como no nosso game s� � poss�vel a bola colidir com o bloco, sempre ser� ela na variavel collision
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Mas aqui garantimos que � a bola que colidiu com o bloco
        if (collision.gameObject.CompareTag("Bola"))
        {
            // Coloquei o som do bloco no GameManager
            // Quando � colocado via inst�ncia de um Prefab, devemos "destruir" o Prefab ap�s um tempo (script DestruirPrefabComOTempo)
            // Instantiate(somBloco);
            FindObjectOfType<GameManager>().RemoverBloco();
            Destroy(this.gameObject);
        }
    }
}
