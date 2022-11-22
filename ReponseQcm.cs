/***********************************************************************
 * Module:  ReponseQcm.cs
 * Author:  FUJITSU
 * Purpose: Definition of the Class ReponseQcm
 ***********************************************************************/

using System;
using Reponse;

namespace ReponseQcm { 
public class ReponseQcm :Reponse{
    private string reponse;


   public ReponseQcm(int id, int IdQuestion, string reponse)
    {
        base.Reponse(id, IdQuestion);
        this.reponse = reponse;
    }

    public string getReponse() { return this.reponse; }
    public void setReponse(string reponse) { this.reponse = reponse; }

}}