using System;
using UnityEngine;

[Serializable]

struct VectoresNuevos
{
    public float x;
    public float y;

    public VectoresNuevos (float x, float y)
    {
        this.x = x;
        this.y = y;
    }

    public void Draw (Color color)
    {
        Debug.DrawLine(
            Vector3.zero, new Vector3(x, y), color
            );
    }

    public void Draw(VectoresNuevos newOrigin, Color color)
    {
        Debug.DrawLine(
            new Vector3(newOrigin.x, newOrigin.y, 0),
            new Vector3(newOrigin.x + x, newOrigin.y + y, 0),
            color
            );
    }

    public static VectoresNuevos operator +(VectoresNuevos a, VectoresNuevos b)
    {
        
        return new VectoresNuevos(a.x + b.x, a.y + b.y);
    }

    public static VectoresNuevos operator -(VectoresNuevos a, VectoresNuevos b)
    {

        return new VectoresNuevos(a.x - b.x, a.y - b.y);
    }

    public static VectoresNuevos operator *(VectoresNuevos a, float b)
    {

        return new VectoresNuevos(a.x * b, a.y * b);
    }

}

