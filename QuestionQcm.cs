/***********************************************************************
 * Module:  QuestionQcm.cs
 * Author:  FUJITSU
 * Purpose: Definition of the Class QuestionQcm
 ***********************************************************************/

using System;
using Question;


public class QuestionQcm : Question
{
   
   private ReponseQcm Reponse;

   public QuestionQcm(int id, int IdExamen, string EnnonceQuestion, int NumQuestion) 
    {
        base.Question(id, IdExamen, EnnonceQuestion, NumQuestion);
    }
    }

}