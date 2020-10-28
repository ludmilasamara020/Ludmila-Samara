using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControleJogador : MonoBehaviour
{
    public float velocidade = 2;
    Vector3 direção;

    //cor 0 = base
    //cor 1 = amarelo
    //cor 2 = ciano
    //cor 3 = rosa
    //cor 4 = verde
    //cor 5 = laranja
    public Material corbase;
    public Material ciano;
    public Material amarelo;
    public Material rosa;
    public Material verde;
    public Material laranja;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        direção = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        transform.Translate(direção * velocidade * Time.deltaTime);
        print(Input.GetAxis("Horizontal"));

    }


    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Finish")
        {
            Time.timeScale = 0;
        }
        print("Colidi com " + other.gameObject.name);
        if (other.GetComponent<Vermelho>() != null)
        {
            Morre();

        }
        else if (other.GetComponent<Verde>() != null)
        {
            this.gameObject.GetComponent<Renderer>().material = verde;

        }
        else if (other.GetComponent<Ciano>() != null)
        {
            this.gameObject.GetComponent<Renderer>().material = ciano;

        }
        else if (other.GetComponent<Amarelo>() != null)
        {
            this.gameObject.GetComponent<Renderer>().material = amarelo;

        }
        else if (other.GetComponent<Rosa>() != null)
        {
            this.gameObject.GetComponent<Renderer>().material = rosa;

        }
        else if (other.GetComponent<Laranja>() != null)
        {
            this.gameObject.GetComponent<Renderer>().material = laranja;

        }
    }
private void Morre()
    {
        Destroy(this.gameObject);
    }
}
