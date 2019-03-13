using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControladorOculto : MonoBehaviour
{
    public void CargaOculto()
    {
        ControladorOculto.LoadScene("NivelOculto");
    }

    private static void LoadScene(string v)
    {
        throw new NotImplementedException();
    }
}
