/***********************************************************************
 * Module:  Reponse.cs
 * Author:  FUJITSU
 * Purpose: Definition of the Class Reponse
 ***********************************************************************/

using System;
namespace Reponse
{
    public abstract class Reponse
    {
        private int id;
        private int IdQuestion;
        

        public Reponse(int id,int IdQuestion)
        {
            this.id = id;
            this.IdQuestion = IdQuestion;
            
        }
        //getters
        public int getId() { return this.id; }
        public int getIdQuestion() { return this.IdQuestion; }
        
        //setters
        public void setId(int id) { this.id = id; }
        public void setIdQuestion(int IdQuestion) { this.IdQuestion= IdQuestion; }
        

    }
}

