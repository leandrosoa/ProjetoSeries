using System;
using System.Collections.Generic;
using Dio.Series.Interfaces;

namespace DIO.Series
{
    public class SerieRepositorio : IRepositorio<Serie> 
    {
       private List<Serie> ListaSerie = new List<Serie>();

       public void Atualiza(int id, Serie entidade) 
       {
           listaSerie[id] = objeto; 
       }

       public void Exclui(int id)
       {
           listaSerie[id].Excluir();
       }

       public void Insere(Serie entidade)
       {
           listaSerie.Add(objeto);
       }

       public List<Serie> Lista()
       {
           return listaSerie;
       }

       public int ProximoId()
       {
           return listaSerie.Count;
       }

       public Serie RetornaPortId(int id)
       {
           return listaSerie[id];
       }
    }
}