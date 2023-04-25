using System.Collections;
using System.Collections.Generic;
using UnityEngine;
  using TMPro;
public class GerenciaPerguntas : MonoBehaviour
{
    public static TMP_InputField ifield;
   
    public void selecionaEspaço (TMP_InputField textField)
    {
        print ("A");
        ifield = textField;

    }

}
