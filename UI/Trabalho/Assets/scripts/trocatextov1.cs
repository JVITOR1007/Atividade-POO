using TMPro;
using UnityEngine;

public class trocatextov1 : MonoBehaviour
{
   public string texto; 
   public TextMeshProUGUI textoUI;

   public void TrocaTextoUI()
   {
      textoUI.text = texto;
   }
   
   
   
}
