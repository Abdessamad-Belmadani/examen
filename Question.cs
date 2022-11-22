/***********************************************************************
 * Module:  Question.cs
 * Author:  FUJITSU
 * Purpose: Definition of the Class Question
 ***********************************************************************/

using System;
namespace Question
{
    public abstract class Question
    {

        private int id;
        private int IdExamen;
        private string EnnonceQuestion;
        private int NumQuestion;

        public Question(int id,int IdExamen, string EnnonceQuestion, int NumQuestion)
        {
            this.id = id;
            this.IdExamen = IdExamen;
            this.EnnonceQuestion = EnnonceQuestion;
            this.NumQuestion = NumQuestion;

        }
        public int GetId()
        {
            return this.id;
        }
        public void SetId(int id)
        {
            this.id=id;
        }
        public int GetIdExamen()
        {
            return this.IdExamen;
        }
        public void SetIdExamen(int IdExamen)
        {
            this.IdExamen = IdExamen;
        }
        public string GetEnnonceQuestion()
        {
            return this.EnnonceQuestion;
        }
        public void SetEnnonceQuestion(string EnnonceQuestion)
        {
            this.EnnonceQuestion = EnnonceQuestion;
        }
        public int GetNumQuestion()
        {
            return this.NumQuestion;
        }
        public void SetNumQuestion(int NumQuestion)
        {
            this.NumQuestion = NumQuestion;
        }
        public void RepondreQuestion()
        {
            // TODO: implement
        }
    }
}

