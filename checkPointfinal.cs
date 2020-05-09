using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkPointfinal : MonoBehaviour
{
float sum (float a,float b)
{
float resultat = a+b;
return resultat;
}
float prod (float a,float b)
{
float resultat = a*b;
return resultat;
}
float division (float a, float b)
{
float resultat = 0;
if(b == 0)
Debug.Log ("erreur");   
else{
resultat = a/b;    
}
return resultat;
}
}