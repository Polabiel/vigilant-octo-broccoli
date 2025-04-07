# 📖 vigilant-octo-broccoli

Bem-vindo ao repositório `vigilant-octo-broccoli`! 🎉 Este projeto, conhecido como "Chico repository two", é utilizado para gerenciar e processar arquivos de texto, realizando a referência cruzada das palavras encontradas neles. Este repositório é ideal para estudos de Estrutura de Dados em C#.

## 📚 Índice

- [Introdução](#-introdução)
- [Uso](#-uso)
- [Contribuição](#-contribuição)
- [Licença](#-licença)
- [Contato](#-contato)

## 📖 Introdução

O `vigilant-octo-broccoli` é um aplicativo que permite a leitura de arquivos de texto e a criação de um relatório de referência cruzada. Ele analisa cada linha do arquivo, separa as palavras e verifica se elas já existem em uma lista de referências. Caso a palavra não exista, ela é adicionada à lista junto com o número da linha onde foi encontrada. Se a palavra já existir, apenas o número da linha é adicionado ao final da lista de linhas dessa palavra. Este projeto é perfeito para quem deseja aprender sobre Estrutura de Dados, como listas ligadas, em C#.

## 🗂️ Estrutura do Projeto

Aqui estão alguns dos arquivos importantes do projeto e suas descrições:

- `IRegistro.cs`: Define uma interface com o método `FormatoDeArquivo()` que deve ser implementado pelas classes que a utilizarem.
- `Form1.cs`: Contém a lógica principal do formulário, incluindo o processamento do arquivo de texto e a geração do relatório de referência cruzada.
- `Form1.Designer.cs`: Contém o código gerado automaticamente pelo Windows Forms Designer para definir os componentes da interface gráfica do usuário.
- `Form1.resx`: Contém recursos utilizados pelo formulário, como strings e configurações de layout.
- `App.config`: Arquivo de configuração do aplicativo, especificando a versão do .NET Framework utilizada.
- `.gitignore`: Arquivo que especifica quais arquivos e diretórios devem ser ignorados pelo Git.
- `LICENSE`: Arquivo de licença do projeto (MIT License).

## ⚙️ Instalação

Para instalar e configurar o projeto localmente, siga os passos abaixo:

1. Clone o repositório:
   ```bash
   git clone https://github.com/Polabiel/vigilant-octo-broccoli.git
   ```
2. Navegue até o diretório do projeto:
   ```bash
   cd vigilant-octo-broccoli
   ```
3. Instale as dependências:
   ```bash
   dotnet restore
   ```

## 🚀 Uso

Para utilizar o aplicativo, siga os passos abaixo:

1. Abra o aplicativo.
2. Clique no botão "Processar". 🖱️
3. Selecione o arquivo de texto que deseja processar. 📄
4. O aplicativo irá gerar um relatório de referência cruzada, listando as palavras encontradas e os números das linhas onde elas aparecem. 📊

## 🤝 Contribuição

Contribuições são bem-vindas! Siga os passos abaixo para contribuir:

1. Faça um fork do projeto. 🍴
2. Crie um branch para sua feature/fix:
   ```bash
   git checkout -b minha-feature
   ```
3. Commit suas mudanças:
   ```bash
   git commit -m 'Adiciona minha feature'
   ```
4. Envie para o branch:
   ```bash
   git push origin minha-feature
   ```
5. Abra um Pull Request. 📥

## 📄 Licença

Este projeto está licenciado sob a licença MIT. Veja o arquivo [LICENSE](LICENSE) para mais detalhes.

## 📬 Contato

Se você tiver alguma dúvida, sinta-se à vontade para contatar Gabriel. 📧
