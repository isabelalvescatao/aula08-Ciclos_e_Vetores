// Essa é a lista de filmes disponibilizada pelo professor inicialmente.
String[] listaDeFilmes = { "Clube dos Cinco", "A Hora do Pesadelo", "Karatê Kid", "Rocky IV", "Conan, o Bárbaro", "Highlander" };

// 1.1. Apresenta todos os filmes da lista separados por ponto e vírgula.
string apresentaTodosOsFilmesSeparadosPorPontoVirgula()
{
    string lista = " ";
    Console.WriteLine(lista);
    for (int indice = 0; indice < listaDeFilmes.Length; indice++)
    {
        lista += $"{listaDeFilmes[indice]}";
        if (indice != (listaDeFilmes.Length - 1))
        {
            lista += "; ";
        }
    }
    return lista;
}

// 1.2. Apresentar quantidade de filmes da lista.
int quantidadeTotalDeFilmes()
{
    int quantidadeTotal = listaDeFilmes.Length;
    return quantidadeTotal;
}

/*
// 1.3. Buscar o nome do filme de acordo com seu índice.
string buscarNomeDoFilmePeloIndice(int indiceDoFilme)
{

}

// 1.4. Adiciona um novo filme a lista pelo seu nome.
String[] adicionaUmNovoFilmePeloSeuNome(string nomeDoFilme)
{

}

// 1.5. Atualiza um filme a partir do seu índice na lista.
String[] atualizarUmFilmePeloSeuIndice(int indiceDoFilme)
{

}
*/

// 1.6. Listar todos os filmes com seu índice/posição na lista.
String[] listarTodosOsFilmesComSeuIndiceNaLista()
{
    string[] listaComIndice = new string[listaDeFilmes.Length];
    int count;
    for (count = 0; count < listaDeFilmes.Length; count++)
    {
        listaComIndice[count] = $"{count} - {listaDeFilmes[count]}";

    }

    return listaComIndice;

}


// Resultado esperado em sua solução.
Console.WriteLine("---------- Resultados da Atividade ----------");

// 1.1 Retorna Clube dos Cinco; A Hora do Pesadelo; Karatê Kid; Rocky IV; Conan, o Bárbaro; Highlander
Console.WriteLine($"1.1. Lista de todos os filmes separados por ponto e vírgula: {apresentaTodosOsFilmesSeparadosPorPontoVirgula()}");

// 1.2 Retorna o número 7.
Console.WriteLine($"1.2. Retorna a quantidade de filmes da lista: {quantidadeTotalDeFilmes()}");

/*
// 1.3 Se o índice for 0, retorna Clube dos Cinco;
Console.WriteLine("1.3. Buscar um filme pelo indice", buscarNomeDoFilmePeloIndice(0));

// 1.4 Se o filme for Sexta-feira 13th, retorna Clube dos Cinco; A Hora do Pesadelo; Karatê Kid; Rocky IV; Conan, o Bárbaro; Highlander, Sexta-feira 13th
Console.WriteLine("1.4. Adiciona um filme pelo nome", adicionaUmNovoFilmePeloSeuNome("Sexta-feira 13th"));

// 1.5 Se o índice for 3 e o nome for atualizado para Rocky III, retorna Clube dos Cinco; A Hora do Pesadelo; Karatê Kid; Rocky III; Conan, o Bárbaro; Highlander, Sexta-feira 13th
Console.WriteLine("1.5. Atualizar um filme pelo seu índice", atualizarUmFilmePeloSeuIndice(3));
*/

/* 1.6 Retorna 
0 - Clube dos Cinco 
1 - A Hora do Pesadelo 
2 - Karatê Kid
3 - Rocky III
4 - Conan, o Bárbaro
5 - Highlander
6 - Sexta-feira 13th */
Console.WriteLine("1.6. Listar todos os filmes com seu indice/posicao na lista:");

string[] listaDeTodosOsFilmesComIndice = listarTodosOsFilmesComSeuIndiceNaLista();
foreach (string filme in listaDeTodosOsFilmesComIndice)
{
    Console.WriteLine($"\t{filme}");
}