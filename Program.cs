﻿using Desafio_SistemaCelular.Models;

System.Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "123456", modelo: "Modelo 1", imei: "111111111", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

System.Console.WriteLine("\n");

System.Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone(numero: "4987", modelo: "Modelo 22", imei: "222222222", memoria: 128);
nokia.Ligar();
nokia.InstalarAplicativo("Telegram");