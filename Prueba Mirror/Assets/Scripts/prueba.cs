using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MasterServerToolkit.Networking;
using System;
using Mirror;


public class prueba : MonoBehaviour
{
    public string host;
    public string path;
    public int port;

    public NetworkManager _nM;

    // El transport asignado al componente NetworkManager debe de ser simpleWebTransport
    public void Awake()
    {
        //Generamos el URI para la conexión con el servidor
        DatosConexion.UriConexion = new UriBuilder { Scheme = "ws", Host = host, Port = port, Path = path }.Uri;

        //Hacemos que el networkManager se conecte como cliente con el servidor mediante la Uri 
        _nM.StartClient(DatosConexion.UriConexion);
    }

    WebSocket ws;

    // Start is called before the first frame update
    void Start()
    {

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
