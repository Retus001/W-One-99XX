using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hover : MonoBehaviour
{
    //Varaibles publcias
    public float DistanciaVuela;
    public float Acceleracion;
    public float VelocidadMaxima;
    public float VelocidadRotacion;

    //Variables privadas
    Vector3 PushVector;

    //Referencias
    Rigidbody rigi;
    ConstantForce constForce;

	//Solo para control
	[System.NonSerialized]
	public float Vertical;
	[System.NonSerialized]
	public float Horizontal;


    void Start ()
    {
        rigi = GetComponent<Rigidbody>();
        constForce = GetComponent<ConstantForce>();
	}

    private void Update()
    {
        //float Vertical = Input.GetAxis("Vertical");

        PushVector = transform.forward * Vertical; //Movemos

        //Nunca debemos empujar en Y
        PushVector.y = 0f;

        //Rotacion--------------
        //float Horizontal = Input.GetAxis("Horizontal");

        if(Horizontal != 0f)
        {
            transform.Rotate(0f, VelocidadRotacion * Horizontal * Time.deltaTime, 0f);
        }
    }	
	
	void FixedUpdate ()
    {
        RaycastHit hit;
        Ray rayo = new Ray(transform.position, Vector3.down);
        
        //rayo que genera el flote
        if(Physics.Raycast(rayo, out hit, DistanciaVuela))
        {
            constForce.enabled = true;
        }
        else
        {
            constForce.enabled = false;
        }

        if(VelocityWithoutY() < VelocidadMaxima) //Solo aplicamos si no ah llegado a velocidad maxima
        {
            rigi.AddForce(PushVector * Acceleracion);
        }
	}

    //Calculamos su velocidad sin tomar en cuenta en Y
    float VelocityWithoutY()
    {
        Vector2 vel = new Vector2(rigi.velocity.x, rigi.velocity.z);
        return vel.magnitude;
    }
}
