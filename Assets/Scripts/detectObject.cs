using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class detectObject : MonoBehaviour
{
    public string tagSphere = "Sphere";
    public string tagArrow = "Arrow";
    public float speed = 30;
   /// public Rotation rotacion;
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag(tagSphere))
        {                
            GetComponent<Rigidbody>().isKinematic = true;
            transform.parent = other.transform;
            
        }
        if (other.gameObject.CompareTag(tagArrow))
        {                
           
           GameObject.Find("Canvas").GetComponent<Canvas>().enabled = true;
           Application.Quit();
        }
       
    }
 
}
