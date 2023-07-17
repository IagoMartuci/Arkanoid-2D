using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestruirPrefabComOTempo : MonoBehaviour
{
    public float tempoParaDestruir;

    // Start is called before the first frame update
    void Start()
    {
        // Diz para a Unity destruir o gameObject que estiver com este script
        // Neste caso, destroi o prefabs de som dos blocos
        Destroy(this.gameObject, tempoParaDestruir);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
