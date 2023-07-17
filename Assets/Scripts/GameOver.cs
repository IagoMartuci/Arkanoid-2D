using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// Para reconher comandos de recarregamento de cena
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Se o objeto que colidiu com a trigger tiver a tag "Bola" (que nesse caso sempre será true), faz o if abaixo:
        if (collision.gameObject.CompareTag("Bola"))
            // Diz para a Unity carregar uma cena
            // Nesse caso, a cena recarregada é a que está entre parenteses depois do LoadScene
            // O GetActiveScene().name diz para a Unity pegar a cena que estamos no momento de acordo com o nome dela
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
