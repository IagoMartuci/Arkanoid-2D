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

    // A variavel collison que o método recebe são os outros game objects da cena
    // Como no nosso game só é possível a bola colidir com o bloco, sempre será ela na variavel collision
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Mas aqui garantimos que é a bola que colidiu com o bloco
        if (collision.gameObject.CompareTag("Bola"))
        {
            // Coloquei o som do bloco no GameManager
            // Quando é colocado via instância de um Prefab, devemos "destruir" o Prefab após um tempo (script DestruirPrefabComOTempo)
            // Instantiate(somBloco);
            FindObjectOfType<GameManager>().RemoverBloco();
            Destroy(this.gameObject);
        }
    }
}
