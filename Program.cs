using DesafioPOO.Models;

Iphone iphone = new Iphone("123456", "iPhone 14", "111111", 128);
iphone.Ligar();
iphone.InstalarAplicativo("WhatsApp");

Nokia nokia = new Nokia("654321", "Nokia Tijolão", "222222", 64);
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Snake");
