namespace ByteBank1.Ententies;

public class Client {

    public int CPF { get; set; } //atributos ja com os metodos get e set
    public string Name { get; set; }
    public string PassWord { get; set; }

    public Client(int cpf, string name, string password) //construtor
    {
        CPF = cpf;
        Name = name;
        PassWord = password; 
    }


}

