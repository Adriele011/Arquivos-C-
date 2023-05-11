using System.Collections;
using System;

using System.Collections.Generic;
using UnityEngine;
  using TMPro;
public class GerenciaPerguntas : MonoBehaviour
{
    public int quantidade;
    private string titulo, pergunta,resposta;
    private int[] simbolos = new int [3];
    private List <Pergunta> perguntas;

public static TMP_InputField ifield;
   public GerenciaPerguntas(){
    titulo= "Complete o nome para nos conhecermos";
    pergunta= "Olá, eu me chamo...";
    CriarPerguntas();
    System.Random randNum = new System.Random();

Pergunta p =perguntas[randNum.Next(4)];

titulo = p.titulo;
pergunta = p.pergunta;
resposta = p.resposta;
   }
   public string getTitulo(){
    return titulo;
   }
    public string getPergunta(){
    return pergunta;
   }
    public string getResposta(){
    return resposta;
   }
    public void selecionaEspaço (TMP_InputField textField)
    {
        print ("A");
        ifield = textField;

    }

private void CriarPerguntas(){
    perguntas = new List<Pergunta>();
    Pergunta p = new Pergunta();
    p.titulo= "teste 1";
    p.pergunta="oergunta teste 1";
    p.resposta = "ANA";
    perguntas.Add(p);
     p = new Pergunta();
    p.titulo= "teste 2";
    p.pergunta="oergunta teste 2";
    p.resposta = "ANE";
    perguntas.Add(p);
     p = new Pergunta();
    p.titulo= "teste 3";
    p.pergunta="oergunta teste 3";
    p.resposta = "ANO";
    perguntas.Add(p);
     p = new Pergunta();
    p.titulo= "teste 4";
    p.pergunta="oergunta teste 4";
    p.resposta = "ANI";
    perguntas.Add(p);

}

}
