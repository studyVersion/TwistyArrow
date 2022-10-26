using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    private float velocidad = 1f;
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
            float aux = Random.Range(-2f, 2f);

            if (aux == 0) {
              aux += 1f;
            }
            velocidad = aux;
          }
    }
}


