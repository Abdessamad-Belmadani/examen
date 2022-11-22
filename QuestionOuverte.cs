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
    

   public QuestionOuverte(int IdExamen, string EnnonceQuestion, int NumQuestion) :base(IdExamen,EnnonceQuestion, NumQuestion)
    {
        
    }
}