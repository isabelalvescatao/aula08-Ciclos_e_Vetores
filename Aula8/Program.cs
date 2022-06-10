// Essa é a lista de filmes disponibilizada pelo professor inicialmente.
String[] listaDeFilmes = { "Clube dos Cinco", "A Hora do Pesadelo", "Karatê Kid", "Rocky IV", "Conan, o Bárbaro", "Highlander" };

// 1.1. Apresenta todos os filmes da lista separados por ponto e vírgula.
string apresentaTodosOsFilmesSeparadosPorPontoVirgula()
{

}

// 1.1. Apresentar quantidade de filmes da lista.
int quantidadeTotalDeFilmes()
{

}

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

// 1.6. Listar todos os filmes com seu índice/posição na lista.
String[] listarTodosOsFilmesComSeuIndiceNaLista()
{

}


// 2. Resultado esperado em sua solução.
Console.WriteLine("------ Resultados da Atividade ------");

// Retorna Clube dos Cinco; A Hora do Pesadelo; Karatê Kid; Rocky IV; Conan, o Bárbaro; Highlander
Console.WriteLine($"1. Lista de todos os filmes separados por ponto e vírgula {apresentaTodosOsFilmesSeparadosPorPontoVirgula()}");

// Retorna o número 7.
Console.WriteLine($"2. Retorna a quantidade de filmes da lista", { quantidadeTotalDeFilmes()}
");

// Se o índice for 0, retorna Clube dos Cinco;
Console.WriteLine("3. Buscar um filme pelo indice", buscarNomeDoFilmePeloIndice(0));

// Se o filme for Sexta-feira 13th, retorna Clube dos Cinco; A Hora do Pesadelo; Karatê Kid; Rocky IV; Conan, o Bárbaro; Highlander, Sexta-feira 13th
Console.WriteLine("4. Adiciona um filme pelo nome", adicionaUmNovoFilmePeloSeuNome("Sexta-feira 13th"));

// Se o índice for 3 e o nome for atualizado para Rocky III, retorna Clube dos Cinco; A Hora do Pesadelo; Karatê Kid; Rocky III; Conan, o Bárbaro; Highlander, Sexta-feira 13th
Console.WriteLine("5. Atualizar um filme pelo seu índice", atualizarUmFilmePeloSeuIndice(3));

// Retorna 
// 0 - Clube dos Cinco 
// 1 - A Hora do Pesadelo 
// 2 - Karatê Kid
// 3 - Rocky III
// 4 - Conan, o Bárbaro
// 5 - Highlander
// 6 - Sexta-feira 13th
Console.WriteLine("6. Listar todos os filmes com seu indice/posicao na lista.", listarTodosOsFilmesComSeuIndiceNaLista());
