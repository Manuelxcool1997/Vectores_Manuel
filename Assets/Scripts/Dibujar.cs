using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dibujar : MonoBehaviour
{ 
   float tamaño = 0;

    private VectoresNuevos Vector1 = new VectoresNuevos(2, 3);
    private VectoresNuevos Vector2 = new VectoresNuevos(3, 4);
    void Start()
    {
        Vector2 au = new Vector2(2, 3);
        Vector2 bu = new Vector2(4, 5);
    }


    void Update()
    {
       Vector1.Draw(Color.green);
        Vector2.Draw(Color.blue);

    

      
        VectoresNuevos combinados = (Vector2 + Vector1)*tamaño;

        combinados.Draw(Vector1, Color.gray);


      VectoresNuevos final = combinados + Vector1;
        final.Draw(Color.yellow);
        
        
        
    }
}
