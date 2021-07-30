using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

public class state : MonoBehaviour
{
 public static state estadojuego;   
 public int estado;
 private string rutaArchivo;
    void Awake()
    {        
        rutaArchivo = (Application.persistentDataPath + "/datos.dat"); 
        if(estadojuego == null)
        {
            estadojuego = this;
            DontDestroyOnLoad(gameObject);            
        }else if(estadojuego != this)
        {
            Destroy(gameObject);            
        }
        Cargar();
    }       
    public void Guardar()
    {
        BinaryFormatter br = new BinaryFormatter();
        FileStream file = File.Create(rutaArchivo);

        DatosAG datos = new DatosAG();
        datos.estadof = estado;
        br.Serialize(file,datos);
        file.Close();
    }
    public void Cargar()
    {
        if(File.Exists(rutaArchivo))
        {
            BinaryFormatter br = new BinaryFormatter();
            FileStream file = File.Open(rutaArchivo, FileMode.Open);
            DatosAG datos = (DatosAG) br.Deserialize(file);        
            estado = datos.estadof;
            file.Close();
        }else{
            estado = 0;
        }

    }
    [Serializable]
    class DatosAG{
        public int estadof;
    }
}
