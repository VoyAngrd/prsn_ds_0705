using System;

public class Pessoa
{
    public string nome;
    public string sobrenome;
    public int idade;
    public string dataNascimento;
    public string nomeMae;
    public string nRG;
    public string nCPF;

    public string getString(string mensagem, string mensagemErro)
    {
        string str;
        bool testErro;

        // Incrementando as mensagens
            mensagem = mensagem + "\n\n=> ";
            mensagemErro = "Erro! Texto inválido\n\n" + mensagemErro + "\n\n=> ";

        Console.Write(mensagem);

        do {
            str = Console.ReadLine();

            testErro = String.IsNullOrEmpty(str);

            if (testErro) {
                Console.Clear();
                Console.Write(mensagemErro);
            }
        } while (testErro);
        
        Console.Clear();
        return str;
    }
    
    public int getInt(string mensagem, string mensagemErro) {
        int vlr;
        bool testErro;

        // Incrementando as mensagens
            mensagem = mensagem + "\n\n=> ";
            mensagemErro = "Erro! Valor inválido\n\n" + mensagemErro + "\n\n=> ";

        Console.Write(mensagem);

        do
        {
            testErro = !(int.TryParse(Console.ReadLine(), out vlr));

            if (testErro || vlr < 0)
            {
                Console.Clear();
                Console.Write(mensagemErro);
            }
        } while (testErro);

        Console.Clear();
        return vlr;
    }

    public void getInfo() {
        Console.Write("Próxima pessoa!");
        Console.Read();
        Console.Clear();
        
        this.nome = getString("Insira seu nome.", "Insira novamente seu nome.");

        this.sobrenome = getString("Insira seu sobrenome.", "Insira novamente seu sobrenome.");

        this.idade = getInt("Insira sua idade.", "Insira novamente sua idade.");

        this.dataNascimento = getString("Insira sua data de nascimento.", "Insira novamente sua data de nascimento.");

        this.nomeMae = getString("Insira o nome da sua mãe.", "Insira novamente o nome da sua mãe.");

        this.nRG = getString("Insira o número do seu RG.", "Insira novamente o número do seu RG.");

        this.nCPF = getString("Insira o número do seu CPF.", "Insira novamente o número do seu CPF.");
    }

    public void showInfo(string objNome) {
        Console.WriteLine
        (
            objNome +
            "\n" +
            "\nNome: " + this.nome +
            "\nSobrenome: " + this.sobrenome +
            "\nIdade: " + this.idade +
            "\nData de nascimento: " + this.dataNascimento +
            "\nNome da mãe: " + this.nomeMae +
            "\nNº de RG: " + this.nRG +
            "\nNº de CPF: " + this.nCPF +
            "\n\n\n"
        );
    }
}