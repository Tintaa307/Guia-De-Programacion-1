using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ej09 : MonoBehaviour
{
    public int persona1 = 0;
    public int persona2 = 0;
    public int persona3 = 0;
    // Start is called before the first frame update
    void Start()
    {
        /* Realizá un programa que resuelva el siguiente problema:
        Tres personas aportan diferente capital a una sociedad. Se desea saber qué porcentaje del
        total aportó cada una (indicando nombre y porcentaje) y cuál es el monto del total aportado
        por las tres.
        Ingresar por Inspector el ingreso del capital aportado por cada una de las personas y luego
        mostrar lo pedido en el siguiente formato:
        Nombre: capital aportado: $ … , Porcentaje del capital: %.... , Monto total aportado: $ …. */


        int resultado = persona1 + persona2 + persona3;
        int porcentaje1 = (persona1 / resultado);
        int porcentaje2 = (persona2 / resultado);
        int porcentaje3 = (persona3 / resultado);

        Debug.Log("El porcentaje de la persona 1 es '" + porcentaje1 + "' de la persona 2 es '" +porcentaje2 + "' y de la persona 3 es '" + porcentaje3 + "' y el monto final es " + resultado);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
