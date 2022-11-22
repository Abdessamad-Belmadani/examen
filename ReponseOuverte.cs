/***********************************************************************
 * Module:  ReponseOuverte.cs
 * Author:  FUJITSU
 * Purpose: Definition of the Class ReponseOuverte
 ***********************************************************************/

using System;
using Reponse;

namespace ReponseOuverte { 
public class ReponseOuverte : Reponse { 
    private string reponse;

{
   public ReponseOuverte(int id, int IdQuestion, string reponse)
    {
        base.Reponse(id, IdQuestion);
        this.reponse = reponse;
    }

    public string getReponse() { return this.reponse; }
    public void setReponse(string reponse) { this.reponse = reponse; }

}
}}