using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadoutManager : MonoBehaviour
{
    public static int P1chariot = 0;
    public static int P1animal = 0;
    public static int P1weapon = 0;
    public static int P2chariot = 0;
    public static int P2animal = 0;
    public static int P2weapon = 0;
    public static int P3chariot = 0;
    public static int P3animal = 0;
    public static int P3weapon = 0;
    public static int P4chariot = 0;
    public static int P4animal = 0;
    public static int P4weapon = 0;

    public int _P1chariot = P1chariot;
    public int _P1animal = P1animal;
    public int _P1weapon = P1weapon;
    public int _P2chariot = P2chariot;
    public int _P2animal = P2animal;
    public int _P2weapon = P1weapon;
    public int _P3chariot = P3chariot;
    public int _P3animal = P3animal;
    public int _P3weapon = P1weapon;
    public int _P4chariot = P4chariot;
    public int _P4animal = P4animal;
    public int _P4weapon = P1weapon;


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        _P1chariot = P1chariot;
        _P1animal = P1animal;
        _P1weapon = P1weapon;
        _P2chariot = P2chariot;
        _P2animal = P2animal;
        _P2weapon = P2weapon;
        _P3chariot = P3chariot;
        _P3animal = P3animal;
        _P3weapon = P3weapon;
        _P4chariot = P4chariot;
        _P4animal = P4animal;
        _P4weapon = P4weapon;

    }
    private void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
    }

    #region Getters

    #region P1
    public static int getP1chariot()
    {
        return P1chariot;
    }
    public static int getP1animal()
    {
        return P1animal;
    }
    public static int getP1weapon()
    {
        return P1weapon;
    }
    #endregion
    #region P2
    public static int getP2chariot()
    {
        return P2chariot;
    }
    public static int getP2animal()
    {
        return P2animal;
    }
    public static int getP2weapon()
    {
        return P2weapon;
    }
    #endregion
    #region P3
    public static int getP3chariot()
    {
        return P3chariot;
    }
    public static int getP3animal()
    {
        return P3animal;
    }
    public static int getP3weapon()
    {
        return P3weapon;
    }
    #endregion
    #region P4
    public static int getP4chariot()
    {
        return P4chariot;
    }
    public static int getP4animal()
    {
        return P4animal;
    }
    public static int getP4weapon()
    {
        return P4weapon;
    }
    #endregion

    #endregion
    #region Setters

    #region P1
    public static void setP1chariot(int i)
    {
        P1chariot =  i;
    }
    public static void setP1animal(int i)
    {
        P1animal = i;
    }
    public static void setP1weapon(int i)
    {
        P1weapon = i;
    }
    #endregion
    #region P2
    public static void setP2chariot(int i)
    {
        P2chariot = i;
    }
    public static void setP2animal(int i)
    {
        P2animal = i;
    }
    public static void setP2weapon(int i)
    {
        P2weapon = i;
    }
    #endregion
    #region P3
    public static void setP3chariot(int i)
    {
        P3chariot = i;
    }
    public static void setP3animal(int i)
    {
        P3animal = i;
    }
    public static void setP3weapon(int i)
    {
        P3weapon = i;
    }
    #endregion
    #region P4
    public static void setP4chariot(int i)
    {
        P4chariot = i;
    }
    public static void setP4animal(int i)
    {
        P4animal = i;
    }
    public static void setP4weapon(int i)
    {
        P4weapon = i;
    }
    #endregion

    #endregion

}
