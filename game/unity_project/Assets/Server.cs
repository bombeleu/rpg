﻿using UnityEngine;
using System.Collections;
using System.Net.Sockets;
using System.IO;

public class Server {

	private static TcpClient tcpClient = new TcpClient("127.0.0.1", 8765);
	private static StreamWriter writer = new StreamWriter(tcpClient.GetStream());
	private static StreamReader reader = new StreamReader(tcpClient.GetStream());

	public static void Write(string msg) {
		writer.Write(msg);
		writer.Flush();
	}

	public static void Read() {
		Debug.Log (reader.ReadLine());
	}
}