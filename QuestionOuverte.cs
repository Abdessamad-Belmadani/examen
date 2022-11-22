/***********************************************************************
 * Module:  QuestionOuverte.cs
 * Author:  FUJITSU
 * Purpose: Definition of the Class QuestionOuverte
 ***********************************************************************/

using System;
using Question;


public class QuestionOuverte :Question
{
   private ReponseOuverte Reponse;
    

   public QuestionOuverte(int id, int IdExamen, string EnnonceQuestion, int NumQuestion) 
    {
        base.Question(id,IdExamen,EnnonceQuestion,NumQuestion);
    }
}