using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControleDoPaddle : MonoBehaviour
{
    public float velocidadePaddle;
    public float limiteMaximoX;
    public float limiteMinimoX;
    //public float limiteMaximoY;
    //public float limiteMinimoY;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MovimentarPaddle();
    }

    private void MovimentarPaddle()
    {
        transform.position = new Vector2(Mathf.Clamp(transform.position.x, limiteMinimoX, limiteMaximoX), transform.position.y);
            // Tentei aplicar limitação para movimentação vertical também, mas não consegui:
            // Mathf.Clamp(transform.position.y, limiteMinimoY, limiteMaximoY));

        //if (Input.GetAxisRaw("Horizontal") > 0.01f)
        //    transform.Translate(Vector2.right * velocidadePaddle * Time.deltaTime);

        //if (Input.GetAxisRaw("Horizontal") < -0.01f)
        //    transform.Translate(Vector2.left * velocidadePaddle * Time.deltaTime);

        // OU

        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
            transform.Translate(Vector2.left * velocidadePaddle * Time.deltaTime);

        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
            transform.Translate(Vector2.right * velocidadePaddle * Time.deltaTime);

        // Tentei aplicar a movimentação vertical também, mas não consegui:
        //if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        //    transform.Translate(Vector2.up * velocidadePaddle * Time.deltaTime);

        //if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        //    transform.Translate(Vector2.down * velocidadePaddle * Time.deltaTime);

    }
}
