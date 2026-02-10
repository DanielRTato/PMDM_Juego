using UnityEngine;

public class Rotator : MonoBehaviour // MonoBehaviour es la clase base de la que derivan todos los scripts de Unity, permite que el script se adjunte a un GameObject y tenga acceso a eventos como Start() y Update()
{


    // Update is called once per frame
    void Update()
    {
        transform.Rotate (new Vector3 (15, 30, 45) * Time.deltaTime); // Rota el objeto a 15 grados por segundo en X, 30 en Y y 45 en Z, multiplicado por Time.deltaTime para que sea independiente del frame rate
    }
}
