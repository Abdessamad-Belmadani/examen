/***********************************************************************
 * Module:  Examen.cs
 * Author:  FUJITSU
 * Purpose: Definition of the Class Examen
 ***********************************************************************/

using System;

public class Examen
{
   public Question question;

   private int Duree;
   private DateTime DateDebut;
   private int IdExamen;

    public int GetDuree()
    {
        return this.Duree;
    }

}