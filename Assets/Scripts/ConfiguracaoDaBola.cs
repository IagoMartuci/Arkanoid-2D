using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConfiguracaoDaBola : MonoBehaviour
{
    public float velocidadeBola;
    public Rigidbody2D oRigidbody2D;
    public bool jogoIniciado;
    public AudioSource somBola;
    public float direcaoAleatoriaX;
    public float direcaoAleatoriaY;

    // Start is called before the first frame update
    void Start()
    {
        jogoIniciado = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (jogoIniciado == false)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                MovimentarBola();
                jogoIniciado = true;
            }
        }
    }

    private void MovimentarBola()
    {
        oRigidbody2D.velocity = Vector2.up * velocidadeBola;
    }

    // A variavel collison que o método recebe são os outros game objects da cena
    // Que quando colidirem com a bolinha vai emitir o som da bola
    private void OnCollisionEnter2D(Collision2D collision)
    {
        somBola.Play();
        // Mover a bolinha aleatoriamente um pouco o lado
        oRigidbody2D.velocity += new Vector2(direcaoAleatoriaX, direcaoAleatoriaY);
    }
}
