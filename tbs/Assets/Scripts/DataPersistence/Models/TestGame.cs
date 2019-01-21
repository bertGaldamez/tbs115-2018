﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts.DataPersistence.Models
{
    [Serializable]
    public class TestGame : IDataType
    {
        private System.Random r;
        private int p;
        private string question;
        public Dictionary<string, string> data = new Dictionary<string, string>();
        public Dictionary<string, string> playeranswerdata = new Dictionary<string, string>();
        public Dictionary<string, string> Level1 = new Dictionary<string, string>();
        public Dictionary<string, string> Level2 = new Dictionary<string, string>();

        public TestGame()
        {
            Level1.Clear();
            Level2.Clear();

            /*Preguntas del Reino 1*/
            Level1.Add("1", "Reino 1. Caminas despacio cuando vas a tu cuarto?");
            Level1.Add("2", "Reino 1. Compartes el baño de la casa con tu familia o visitas?");
            Level1.Add("3", "Reino 1, Levantas tu mano para pedir turno en una conversación?");
            Level1.Add("4", "Reino 1, Saludas cuando llegas de visita a casa de un familiar?");
            Level1.Add("5", "Reino 1, Compartes tus pertenencias con otras personas si te lo piden?");
            Level1.Add("6", "Reino 1, Sueles utilizar las palabras 'Por favor' y 'Gracias'?");
            Level1.Add("7", "Reino 1, Si alguien te solicita algo, sueles ayudar?");
            Level1.Add("8", "Reino 1, Si alguien cumple años, sueles felicitarlo?");
            Level1.Add("9", "Reino 1, Si estas enojado, te alejas para tranquilizarte?");
            Level1.Add("10", "Reino 1, Sueles saludar a tus amigos, aunque los veas todos los dias?");
            Level1.Add("11", "Reino 1, Eres capaz de controlar el temor por los sonidos fuertes?");

            /*Preguntas del Reino 2*/
            Level2.Add("1", "Reino 2, Pregunta 1 ?");
            Level2.Add("2", "Reino 2, Pregunta 2 ?");
            Level2.Add("3", "Reino 2, Pregunta 3 ?");
            Level2.Add("4", "Reino 2, Pregunta 4 ?");
            Level2.Add("5", "Reino 2, Pregunta 5 ?");
            Level2.Add("6", "Reino 2, Pregunta 6 ?");
            Level2.Add("7", "Reino 2, Pregunta 7 ?");
            Level2.Add("8", "Reino 2, Pregunta 8 ?");
            Level2.Add("9", "Reino 2, Pregunta 9 ?");
            Level2.Add("10", "Reino 2, Pregunta 10 ?");
            Level2.Add("11", "Reino 2, Pregunta 11 ?");
            Level2.Add("12", "Reino 2, Pregunta 12 ?");
            Level2.Add("13", "Reino 2, Pregunta 13 ?");
            Level2.Add("14", "Reino 2, Pregunta 14 ?");
            Level2.Add("15", "Reino 2, Pregunta 15 ?");
        }
        
        public string GetValueOfKey(string key)
        {
            return data[key].ToString();
        }
        public string LoadDataLocally(string key)
        {
            string Level = data[key].ToString();
            if (GetSetOfQuestions(Level).Count > 0)
            {
                r = new System.Random();
                p = r.Next(1, GetSetOfQuestions(Level).Count);
                Console.WriteLine(p);
                question = GetSetOfQuestions(Level).ElementAt(p).Value;
                DeleteAskedQuestion(Level, p);
                return question;
            }
            else
            {
                throw new ArgumentException("El Key solicitado no existe en el Dictionary correspondiente.", Level);
            }

        }
        public bool SaveDataLocally(string key, string value)
        {
            try
            {
                if (!data.ContainsKey(key))
                {
                    data.Add(key, value);
                    return true;
                }
                else
                {
                    data[key] = value;
                    return true;
                }
            }
            catch (Exception e)
            {
                Debug.LogError(e.Message);
                return false;
            }
        }

        private Dictionary<string, string> GetSetOfQuestions(string level)
        {
            try
            {
                switch (level)
                {
                    case "Level1": return Level1;
                    case "Level2": return Level2;
                    default: return null;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        private void DeleteAskedQuestion(string level, int index)
        {
            GetSetOfQuestions(level).Remove(GetSetOfQuestions(level).ElementAt(index).Key);
        }


    }
}