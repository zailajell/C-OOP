using System;

public class HelloWorld
{
    static public void Main ()
    {
        

Kalkulator hitung = new Kalkulator();

// hitung.tambah();
// hitung.kurang();

Console.Write("masukan alas : ");
int a = Convert.ToInt32( Console.ReadLine() );
Console.Write("masukan tinggi : ");
int t = Convert.ToInt32( Console.ReadLine() );

Rumus rumus = new Rumus();
int luas = rumus.jajargenjang (a,t);

Console.WriteLine($"luas jajargenjang dengan a ={a} dan t={t} adalah {luas}");

    }
    

class Kalkulator
{
public void tambah(){
    Console.WriteLine("tambah");}
public void kurang(){
    Console.WriteLine("kurang");}
}
class Rumus
{
public void lingkaran(){
Console.WriteLine("lingkaran");}
public int jajargenjang(int a,int t){
return a*t;}
}


}

