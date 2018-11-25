﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Minijuego3 : MonoBehaviour
{

    public GameObject personaje1, personaje2, personaje3;
    public GameObject simbolo1, simbolo2, simbolo3;
    public GameObject btnCirculo, btnTriangulo, btnCuadrado, btnMano, btnReset, btnContinue, btnTermina;
    public GameObject msj_ok, msj_fail, msj_complete;

    public GameStatus gs;
    public AudioSource audioSource;
    public AudioClip bgMusic;
    public float timeLeft = 10.00f;
    public bool isGameDone = false;


    public GameObject texto;


    // Text
    public Text Nivel;
    public Text timing;

    //Manejo de Animaciones
    public AnimationClip speak01, speak02, speak03;
    private Animation animacionSpeak1, animacionSpeak2, animacionSpeak3;

    public Sprite Circulo, Triangulo, Cuadrado;

    private int x, y, z, count = 1;
    private string sign;



    // Use this for initialization
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        bgMusic = Resources.Load<AudioClip>("Sounds/TalkingAbout");
        audioSource.PlayOneShot(bgMusic);


        texto = new GameObject();
        texto = GameObject.Find("Timing");
        timing = texto.GetComponent<Text>();

        timing.text = "Tiempo";

        animacionSpeak1 = personaje1.AddComponent<Animation>();
        animacionSpeak2 = personaje2.AddComponent<Animation>();
        animacionSpeak3 = personaje3.AddComponent<Animation>();
        animacionSpeak1.AddClip(speak01, "Speak01");
        animacionSpeak2.AddClip(speak02, "Speak02");
        animacionSpeak3.AddClip(speak03, "Speak03");

        simbolo1.GetComponent<Image>().enabled = false;
        simbolo2.GetComponent<Image>().enabled = false;
        simbolo3.GetComponent<Image>().enabled = false;

        //Ocultar Botones con simbolos
        btnCirculo.SetActive(false);
        btnCuadrado.SetActive(false);
        btnTriangulo.SetActive(false);
        Debug.Log("Valor de count: " + count);
        randomSpeak();


    }

    // Update is called once per frame
    void Update()
    {

        if (!isGameDone)
        {
            timeLeft -= Time.deltaTime;
            timing.text = "Tiempo: " + timeLeft.ToString("0.0");

            if (timeLeft <= 0 && !isGameDone)
            {
                audioSource.Stop();
                isGameDone = true;
                gs = new GameStatus();
                gs.PlayerNeedToRepeatGame(audioSource);
            }
        }
    }

    public void randomSpeak()
    {
        Debug.Log("Valor de count: " + count);

        if (count <= 3)
        {
            //Random Animacion
            x = Random.Range(1, 4);
            Debug.Log("Animacion " + x + " Seleccionada");
            switch (x)
            {
                case 1:
                    //Habla personaje 1
                    //animacionSpeak2.GetComponent<Animation>().Stop("Speak02");
                    //animacionSpeak3.GetComponent<Animation>().Stop("Speak03");
                    animacionSpeak1.GetComponent<Animation>().Play("Speak01");
                    Debug.Log("reproduciendo animacion 1 : " + animacionSpeak1.IsPlaying("Speak01"));

                    //Random de Simbolo para el personaje que habla 
                    y = Random.Range(1, 4);
                    simbolo1.GetComponent<Image>().enabled = true;
                    switch (y)
                    {
                        case 1:
                            simbolo1.GetComponent<Image>().sprite = Triangulo;
                            sign = "triangulo"; //simbolo asignado al personaje que esta hablando
                            break;
                        case 2:
                            simbolo1.GetComponent<Image>().sprite = Circulo;
                            sign = "circulo";
                            break;
                        case 3:
                            simbolo1.GetComponent<Image>().sprite = Cuadrado;
                            sign = "cuadrado";
                            break;
                    }
                    break;
                case 2:
                    //Habla personaje 2
                    //animacionSpeak1.GetComponent<Animation>().Stop("Speak01");
                    //animacionSpeak3.GetComponent<Animation>().Stop("Speak03");
                    animacionSpeak2.GetComponent<Animation>().Play("Speak02");
                    Debug.Log("animacion 2 : " + animacionSpeak2.IsPlaying("Speak02"));

                    //Random de Simbolos 
                    y = Random.Range(1, 4);
                    simbolo2.GetComponent<Image>().enabled = true;
                    switch (y)
                    {
                        case 1:
                            simbolo2.GetComponent<Image>().sprite = Triangulo;
                            sign = "triangulo";
                            break;
                        case 2:
                            simbolo2.GetComponent<Image>().sprite = Circulo;
                            sign = "circulo";
                            break;
                        case 3:
                            simbolo2.GetComponent<Image>().sprite = Cuadrado;
                            sign = "cuadrado";
                            break;
                    }
                    break;
                case 3:
                    //Habla personaje 3
                    //animacionSpeak1.GetComponent<Animation>().Stop("Speak01");
                    //animacionSpeak2.GetComponent<Animation>().Stop("Speak02");
                    animacionSpeak3.GetComponent<Animation>().Play("Speak03");
                    Debug.Log("animacion 3 : " + animacionSpeak3.IsPlaying("Speak03"));

                    //Random de Simbolos 
                    y = Random.Range(1, 4);
                    simbolo3.GetComponent<Image>().enabled = true;
                    switch (y)
                    {
                        case 1:
                            simbolo3.GetComponent<Image>().sprite = Triangulo;
                            sign = "triangulo";
                            break;
                        case 2:
                            simbolo3.GetComponent<Image>().sprite = Circulo;
                            sign = "circulo";
                            break;
                        case 3:
                            simbolo3.GetComponent<Image>().sprite = Cuadrado;
                            sign = "cuadrado";
                            break;
                    }
                    break;
            }
            if (simbolo1.GetComponent<Image>().isActiveAndEnabled)
            {
                //Luego de verificar si simbolo1 esta activado, se activa el simbolo2 
                simbolo2.GetComponent<Image>().enabled = true;
                simbolo3.GetComponent<Image>().enabled = true;
                switch (sign)
                {
                    case "triangulo":
                        z = Random.Range(1, 3);
                        switch (z)
                        {
                            case 1:
                                simbolo2.GetComponent<Image>().sprite = Circulo;
                                simbolo3.GetComponent<Image>().sprite = Cuadrado;
                                break;
                            case 2:
                                simbolo2.GetComponent<Image>().sprite = Cuadrado;
                                simbolo3.GetComponent<Image>().sprite = Circulo;
                                break;
                        }
                        break;
                    case "circulo":
                        z = Random.Range(1, 3);
                        switch (z)
                        {
                            case 1:
                                simbolo2.GetComponent<Image>().sprite = Triangulo;
                                simbolo3.GetComponent<Image>().sprite = Cuadrado;
                                break;
                            case 2:
                                simbolo2.GetComponent<Image>().sprite = Cuadrado;
                                simbolo3.GetComponent<Image>().sprite = Triangulo;
                                break;
                        }
                        break;
                    case "cuadrado":
                        z = Random.Range(1, 3);
                        switch (z)
                        {
                            case 1:
                                simbolo2.GetComponent<Image>().sprite = Circulo;
                                simbolo3.GetComponent<Image>().sprite = Triangulo;
                                break;
                            case 2:
                                simbolo2.GetComponent<Image>().sprite = Triangulo;
                                simbolo3.GetComponent<Image>().sprite = Circulo;
                                break;
                        }
                        break;
                }
            }
            else
            {
                if (simbolo2.GetComponent<Image>().isActiveAndEnabled)
                {
                    simbolo1.GetComponent<Image>().enabled = true;
                    simbolo3.GetComponent<Image>().enabled = true;
                    switch (sign)
                    {
                        case "triangulo":
                            z = Random.Range(1, 3);
                            switch (z)
                            {
                                case 1:
                                    simbolo1.GetComponent<Image>().sprite = Circulo;
                                    simbolo3.GetComponent<Image>().sprite = Cuadrado;
                                    break;
                                case 2:
                                    simbolo1.GetComponent<Image>().sprite = Cuadrado;
                                    simbolo3.GetComponent<Image>().sprite = Circulo;
                                    break;
                            }
                            break;
                        case "circulo":
                            z = Random.Range(1, 3);
                            switch (z)
                            {
                                case 1:
                                    simbolo1.GetComponent<Image>().sprite = Triangulo;
                                    simbolo3.GetComponent<Image>().sprite = Cuadrado;
                                    break;
                                case 2:
                                    simbolo1.GetComponent<Image>().sprite = Cuadrado;
                                    simbolo3.GetComponent<Image>().sprite = Triangulo;
                                    break;
                            }
                            break;
                        case "cuadrado":
                            z = Random.Range(1, 3);
                            switch (z)
                            {
                                case 1:
                                    simbolo1.GetComponent<Image>().sprite = Circulo;
                                    simbolo3.GetComponent<Image>().sprite = Triangulo;
                                    break;
                                case 2:
                                    simbolo1.GetComponent<Image>().sprite = Triangulo;
                                    simbolo3.GetComponent<Image>().sprite = Circulo;
                                    break;
                            }
                            break;
                    }
                }
                else
                {
                    simbolo1.GetComponent<Image>().enabled = true;
                    simbolo2.GetComponent<Image>().enabled = true;
                    switch (sign)
                    {
                        case "triangulo":
                            z = Random.Range(1, 3);
                            switch (z)
                            {
                                case 1:
                                    simbolo1.GetComponent<Image>().sprite = Circulo;
                                    simbolo2.GetComponent<Image>().sprite = Cuadrado;
                                    break;
                                case 2:
                                    simbolo1.GetComponent<Image>().sprite = Cuadrado;
                                    simbolo2.GetComponent<Image>().sprite = Circulo;
                                    break;
                            }
                            break;
                        case "circulo":
                            z = Random.Range(1, 3);
                            switch (z)
                            {
                                case 1:
                                    simbolo1.GetComponent<Image>().sprite = Triangulo;
                                    simbolo2.GetComponent<Image>().sprite = Cuadrado;
                                    break;
                                case 2:
                                    simbolo1.GetComponent<Image>().sprite = Cuadrado;
                                    simbolo2.GetComponent<Image>().sprite = Triangulo;
                                    break;
                            }
                            break;
                        case "cuadrado":
                            z = Random.Range(1, 3);
                            switch (z)
                            {
                                case 1:
                                    simbolo1.GetComponent<Image>().sprite = Circulo;
                                    simbolo2.GetComponent<Image>().sprite = Triangulo;
                                    break;
                                case 2:
                                    simbolo1.GetComponent<Image>().sprite = Triangulo;
                                    simbolo2.GetComponent<Image>().sprite = Circulo;
                                    break;
                            }
                            break;
                    }
                }

            }

        }
        else
        {
            Debug.Log("A completado el minijuego");
            complete();

        }
    }

    public void esCirculo()
    {
        if (btnCirculo.name == sign)
        {
            Ok();
        }
        else
        {
            fail();
        }

        disabledButton();
    }

    public void esTriangulo()
    {
        if (btnTriangulo.name == sign)
        {
            Ok();
        }
        else
        {
            fail();
        }

        disabledButton();
    }

    public void esCuadrado()
    {
        if (btnCuadrado.name == sign)
        {
            Ok();
        }
        else
        {
            fail();
        }

        disabledButton();
    }

    //Accion oculta mano y activa simbolos
    public void accionMano()
    {

        //Ocultar Botones con simbolos
        btnCirculo.SetActive(true);
        btnCuadrado.SetActive(true);
        btnTriangulo.SetActive(true);

        btnMano.SetActive(false);

    }

    //Oculta simbolos de botones
    public void disabledButton()
    {
        btnCirculo.SetActive(false);
        btnCuadrado.SetActive(false);
        btnTriangulo.SetActive(false);
    }

    //Mensaje de respuesta correcta
    public void Ok()
    {
        msj_ok.SetActive(true);
        btnContinue.SetActive(true);
        //count++;
    }

    //Mensaje de Respuesta incorrecta
    public void fail()
    {
        msj_fail.SetActive(true);
        btnReset.SetActive(true);
    }

    //Mensaje de finalizacion de minijuego
    public void complete()
    {
        audioSource.Stop();
        isGameDone = true;
        btnMano.SetActive(false);
        //msj_complete.SetActive(true);
        // btnTermina.SetActive(true);
        gs = new GameStatus();
        gs.PlayerWinGame(audioSource);
    }

    //Restaura el minijuego para la siguiente iteracion
    public void iteracion()
    {
        //Deshabilitar simbolos
        simbolo1.GetComponent<Image>().enabled = false;
        simbolo2.GetComponent<Image>().enabled = false;
        simbolo3.GetComponent<Image>().enabled = false;

        //Deshabilitar botones con simbolo
        disabledButton();

        //Habilitar Mano
        btnMano.SetActive(true);

        //Setando Texto
        Nivel.text = count + "/3";

        //Contador
        count++;

        msj_ok.SetActive(false);
        btnContinue.SetActive(false);

        //Detener todas las animaciones
        animacionSpeak1.GetComponent<Animation>().Stop("Speak01");
        animacionSpeak2.GetComponent<Animation>().Stop("Speak02");
        animacionSpeak3.GetComponent<Animation>().Stop("Speak03");

        randomSpeak();
    }

    public void pruebaRandom()
    {
        Debug.Log("Valor Random: " + Random.Range(1, 4));
    }

}
