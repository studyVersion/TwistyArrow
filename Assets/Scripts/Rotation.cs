using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    private float velocidad = 0.5f;
    private float tiempoCambio = 3;
    void Start()
    {
          StartCoroutine(CambioRotacion());
    }
    void Update()
    {
        transform.Rotate(velocidad,0,0);
        

    }
      IEnumerator CambioRotacion()
    {
        while (true)
         {
            yield return new WaitForSeconds(tiempoCambio);
            float aux = Random.Range(-0.8f, 0.8f);

            if (aux == 0) {
              aux += 0.5f;
            }
            velocidad = aux;
          }
    }
}


