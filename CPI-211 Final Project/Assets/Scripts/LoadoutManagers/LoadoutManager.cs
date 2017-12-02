using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadoutManager : MonoBehaviour
{
    public static int P1chariot = 0;
    public static int P1animal = 0;
    public static int P2chariot = 0;
    public static int P2animal = 0;
    public static int P3chariot = 0;
    public static int P3animal = 0;
    public static int P4chariot = 0;
    public static int P4animal = 0;


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
      

    }
    
    public static int getP1chariot()
    {
        return P1chariot;
    }
    public static int getP1animal()
    {
        return P1animal;
    }
    public static int getP2chariot()
    {
        return P2chariot;
    }
    public static int getP2animal()
    {
        return P2animal;
    }
    public static int getP3chariot()
    {
        return P3chariot;
    }
    public static int getP3animal()
    {
        return P3animal;
    }
    public static int getP4chariot()
    {
        return P4chariot;
    }
    public static int getP4animal()
    {
        return P4animal;
    }
    public static void setP1chariot(int i)
    {
        P1chariot =  i;
    }
    public static void setP1animal(int i)
    {
        P1animal = i;
    }
    public static void setP2chariot(int i)
    {
        P2chariot = i;
    }
    public static void setP2animal(int i)
    {
        P2animal = i;
    }
    public static void setP3chariot(int i)
    {
        P3chariot = i;
    }
    public static void setP3animal(int i)
    {
        P3animal = i;
    }
    public static void setP4chariot(int i)
    {
        P4chariot = i;
    }
    public static void setP4animal(int i)
    {
        P4animal = i;
    }
}
