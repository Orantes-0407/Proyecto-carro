interface IPiloto
{
    string Nombre { get; set; }
    int Edad { get; set; }
    string Tipolicencia { get; set; } //tipo a, b, c y m
                                     
    void mostrarinformacion();
}

