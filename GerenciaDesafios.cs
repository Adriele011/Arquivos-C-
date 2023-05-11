using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class GerenciaDesafios : MonoBehaviour
{ 
     public int quantidade;
    public TMP_Text Titulo;
    public TMP_Text TxtPergunta;
    private GerenciaPerguntas pergunta; 
    private string resposta ="ANA";
    public TMP_InputField[] CaixaDeResposta = new TMP_InputField [3];
    public int x;
    // Start is called before the first frame update
    void Start()
    {
       
    }
  private void Awake()
         {
             pergunta= new GerenciaPerguntas();
         Titulo.text= pergunta.getTitulo();  
         TxtPergunta.text = pergunta.getPergunta();
          }
    // Update is called once per frame
    void Update()
    {
        
    }
    public void verificar ()
    {
print ("verificar");
     string texto= "";
     for (int i = 0; i< CaixaDeResposta.Length ;i++ )
     texto+=CaixaDeResposta[i].text;
     print (pergunta.getResposta());
     
     if (texto==pergunta.getResposta()){
SceneManager.LoadScene(10);
     print ("acertou");
     }
     else{
     print ("errouu");
SceneManager.LoadScene(11);
     } 

    }
    
}
