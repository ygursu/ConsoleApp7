﻿public class Kitap
{
    public int sayfaSayisi;
    public String kitapAdi, yazar;
    Kitap(String kitapAdi, int sayfaSayisi, String yazar)
    {
        this.kitapAdi = kitapAdi;
        this.sayfaSayisi = sayfaSayisi;
        this.yazar = yazar;
    }
}
public class Kitap
{
    public int sayfaSayisi;
    public String kitapAdi, yazar;
    Kitap(String kitapAdi, int sayfaSayisi, String yazar)
    {
        this.kitapAdi = kitapAdi;
        this.yazar = yazar;
        if (sayfaSayisi < 1)
        {
            this.sayfaSayisi = 10;
        }
        else
        {
            this.sayfaSayisi = sayfaSayisi;
        }
    }
}
public class Kitap
{
    private int sayfaSayisi;
    private String kitapAdi, yazar;
    Kitap(String kitapAdi, int sayfaSayisi, String yazar)
    {
        this.kitapAdi = kitapAdi;
        this.yazar = yazar;
        if (sayfaSayisi < 1)
        {
            this.sayfaSayisi = 10;
        }
        else
        {
            this.sayfaSayisi = sayfaSayisi;
        }
    }
}