using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SplashScreen : MonoBehaviour
{

    void Start()
    {
        // chama a fun��o ass�ncrona que levar� � pr�xima tela com um atraso de 2 segundos
        StartCoroutine( "Splashscreen" );

    }


    IEnumerator Splashscreen()
    {
        // aguarda o tempo antes de executar a pr�xima linha
        yield return new WaitForSeconds(8);

        // Navegar para pr�xima tela
        SceneManager.LoadScene("Clicker");
    }
}
