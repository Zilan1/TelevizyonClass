class Televizyon
{
    public int SesSeviyesi { get; set; }
    public double EkranBoyutu { get; set; }
    public string GoruntuTeknolojisi { get; set; }

    bool gucacik = false;
    int kanalNo = 1;
    public void GucAc()
    {
        gucacik = true;
    }
    public void GucKapat()
    {
        gucacik = false;
    }
    public void KanalDegistir(int kanalNo)
    {
        this.kanalNo = kanalNo;
    }
    public int SesSeviyesiOku()
    {
        return SesSeviyesi;
    }
}