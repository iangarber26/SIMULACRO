//2. Crear las variables necesarias para ingresar por Inspector el precio de 3 productos y un monto de dinero disponible. Comunicar si la suma de los mismos supera o no el monto de dinero disponible. Luego indicar cuánto dinero sobra o falta.
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SIMULACRO2 : MonoBehaviour
{
    public int precio1;
    public int precio2;
    public int precio3;
    int suma;
    int resta1;
    int resta2;
    public int monto_disponible;

    // Start is called before the first frame update
    void Start()
    {
        suma = precio1 + precio2 + precio3;
        resta1 = suma - monto_disponible;
        resta2 = monto_disponible - suma;

        if (precio1 + precio2 + precio3 > monto_disponible)
        {
            Debug.Log("Supera el monto de dinero disponible, falta $ " + resta1);
        }
        else
        {
            Debug.Log("No supera el monto de dinero disponible, sobra $ " + resta2);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
