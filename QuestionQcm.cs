/***********************************************************************
 * Module:  QuestionQcm.cs
 * Author:  FUJITSU
 * Purpose: Definition of the Class QuestionQcm
 ***********************************************************************/

using System;
using Question;


public class QuestionQcm : Question
{
   private string[]  Propositions;
   private ReponseQcm Reponse;

   public QuestionQcm(string[] Propositions,int IdExamen, string EnnonceQuestion, int NumQuestion) : base(IdExamen, EnnonceQuestion, NumQuestion)
    {
        this.Propositions = new string[Propositions.L];
    }
    }

}