using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class colocacion : MonoBehaviour
{
    [SerializeField] string nombreobjeto;
    [SerializeField] string puerta;
    public Animator anim;
  
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name== nombreobjeto)
        {
            anim.SetBool("ativarpuerta", true);
            
            Debug.Log("Es correcto");
        }
        else
        {
            anim.SetBool("ativarpuerta", false);
           
            Debug.Log("Es incorrecto");

        }

   
    }

   
}
