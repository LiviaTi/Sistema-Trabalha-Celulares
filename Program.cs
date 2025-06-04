using DesafioPOO.Models;

Nokia n1 = new Nokia(numero:"38A934", modelo:"Nokia C2", imei:"1235HJ", memoria:128);

n1.Ligar();
n1.ReceberLigacao();
n1.InstalarAplicativo("Spotify");


Iphone i1 = new Iphone(numero:"23ACD43", modelo:"Iphone 15", imei:"7635HJ", memoria:256);

i1.Ligar();
i1.ReceberLigacao();
i1.InstalarAplicativo("Tinder");