# 🐾 PetShope - Sistema de Gerenciamento de Pet Shop

Um projeto educacional desenvolvido em **C#** para aprender e consolidar conceitos fundamentais de **Programação Orientada a Objetos (OOP)**, como construtores, relacionamentos entre objetos e estruturas de dados.

---

## 📋 Sobre o Projeto

**PetShope** é uma aplicação de console que simula um sistema de gerenciamento para pet shops. O sistema permite:

- **Adicionar Donos**: Registrar proprietários de animais de estimação
- **Adicionar Pets**: Cadastrar animais de estimação com informações de seus donos
- **Agendar Consultas Veterinárias**: Criar consultas com o veterinário nos horários disponíveis
- **Visualizar Horários de Atendimento**: Consultar os horários de funcionamento do veterinário

Este é um **projeto de aprendizado** focado em reforçar fundamentos de C# e OOP através da prática.

---

## 🛠️ Tecnologias Utilizadas

- **Linguagem**: C#
- **Framework**: .NET Core/Framework
- **IDE**: Visual Studio / VS Code
- **Conceitos Principais**: 
  - Programação Orientada a Objetos (OOP)
  - Construtores e Inicializadores
  - Relacionamentos entre Objetos
  - Coleções (Dictionary, List)
  - Métodos e Propriedades

---

## 📁 Estrutura do Projeto

```
petshope/
├── petshope/
│   ├── primary/              # Classes principais do sistema
│   │   ├── Dono.cs          # Classe para representar donos
│   │   ├── Pet.cs           # Classe para representar pets
│   │   ├── Veterinario.cs   # Classe para gerenciar veterinário e horários
│   │   └── Sistema.cs       # Classe principal do sistema
│   ├── Program.cs            # Ponto de entrada da aplicação
│   ├── petshope.csproj       # Arquivo de projeto
│   └── obj/                  # Arquivos compilados
├── petshope.sln              # Solução Visual Studio
└── README.md                 # Este arquivo
```

---

## 🚀 Como Usar

### Pré-requisitos

- .NET SDK 6.0+ (ou .NET Framework 4.7+)
- Visual Studio 2019+ ou Visual Studio Code com extensão C# (OmniSharp)
- Git (para clonar o repositório)

### Instalação e Execução

1. **Clone o repositório**
   ```bash
   git clone https://github.com/gabriel-braoio/petshope.git
   cd petshope
   ```

2. **Abra a solução no Visual Studio**
   ```bash
   start petshope.sln
   ```
   
   Ou no Visual Studio Code:
   ```bash
   code .
   ```

3. **Restaure as dependências**
   ```bash
   dotnet restore
   ```

4. **Compile o projeto**
   ```bash
   dotnet build
   ```

5. **Execute a aplicação**
   ```bash
   dotnet run
   ```

---

## 💻 Como Usar a Aplicação

Após executar o projeto, você verá um menu interativo:

```
Bem-vindo ao Petshope!
```

**Opções disponíveis:**

- **Opção 1**: Adicionar um novo dono
- **Opção 2**: Adicionar um novo pet (vinculado a um dono)
- **Opção 3**: Criar uma consulta veterinária (visualiza horários disponíveis)

Simplesmente digite o número da opção desejada e siga as instruções na tela.

---

## 📚 Arquitetura e Classes Principais

### `Dono.cs`
Representa um proprietário de animais de estimação.

**Propriedades:**
- Nome
- Contato (telefone/email)

**Métodos:**
- Construtor para inicializar o dono

### `Pet.cs`
Representa um animal de estimação.

**Propriedades:**
- Nome
- Raça
- Idade
- Proprietário (relacionamento com Dono)

**Métodos:**
- Construtor para inicializar o pet
- Métodos para exibir informações

### `Veterinario.cs`
Gerencia informações do veterinário e seus horários de atendimento.

**Propriedades:**
- Horários de atendimento disponíveis

**Métodos:**
- `Horariosdeatendimento()`: Exibe os horários disponíveis
- Métodos para gerenciar consultas

### `Sistema.cs`
Classe central que coordena as operações do sistema.

**Métodos:**
- `adicionardono()`: Permite adicionar um novo dono
- `adicionarpet()`: Permite adicionar um novo pet
- `criarconsulta()`: Permite agendar uma consulta veterinária

### `Program.cs`
Ponto de entrada da aplicação com o menu principal.

---

## 🎯 Funcionalidades Implementadas

- ✅ Menu interativo por console
- ✅ Cadastro de donos
- ✅ Cadastro de pets vinculados a donos
- ✅ Agendamento de consultas veterinárias
- ✅ Visualização de horários disponíveis do veterinário
- ✅ Validação básica de entrada de dados

---

## 📖 Conceitos de OOP Demonstrados

Este projeto prática os seguintes conceitos:

| Conceito | Descrição | Implementação |
|----------|-----------|----------------|
| **Encapsulamento** | Proteção de dados através de propriedades | Classes com propriedades privadas |
| **Construtores** | Inicialização de objetos | Construtores nas classes Dono, Pet |
| **Relacionamentos** | Associação entre objetos | Pet contém referência a Dono |
| **Métodos** | Comportamento dos objetos | Métodos para adicionar, listar, agendar |
| **Collections** | Armazenamento de múltiplos objetos | List<> e Dictionary<> para gerenciar dados |

---

## 🔄 Fluxo da Aplicação

```
┌─────────────────────┐
│   Iniciar Programa  │
└──────────┬──────────┘
           │
      ┌────▼────┐
      │   Menu  │
      └────┬────┘
           │
    ┌──────┴──────┬──────────┬──────────┐
    │             │          │          │
    ▼             ▼          ▼          ▼
┌────────────┐ ┌────────┐ ┌─────┐ ┌──────────┐
│Adicionar   │ │Adicionar│ │Criar│ │ Opção   │
│  Dono      │ │  Pet    │ │Consul│ │ Inválida│
└────────────┘ └────────┘ └─────┘ └──────────┘
    │             │          │
    └─────────┬───┘          │
              │              │
              ▼              ▼
        ┌──────────┐    ┌─────────┐
        │ Salvar   │    │  Sair   │
        │ Dados    │    │ Sistema │
        └──────────┘    └─────────┘
```

---

## 💡 Melhorias Futuras

- 🔜 Persistência em banco de dados SQL
- 🔜 Interface gráfica (WPF ou WinForms)
- 🔜 Sistema de relatórios
- 🔜 Gestão de pagamentos
- 🔜 Histórico de consultas
- 🔜 Notificações de agendamentos
- 🔜 Filtros e busca avançada

---

## 📝 Notas Importantes

Este é um **projeto educacional**, portanto:

- O foco está em aprender OOP e C#
- O código prioriza clareza e legibilidade
- Algumas funcionalidades são simplificadas para fins de aprendizado
- Sem interface gráfica (apenas console)
- Sem persistência em banco de dados (dados em memória)

---

## 📄 Licença

Este projeto é fornecido como-está para fins educacionais. Sinta-se livre para usar, estudar e modificar o código.

---

## 🙌 Feedback e Contribuições

Se você tem sugestões de melhorias, encontrou bugs ou gostaria de contribuir:

1. Abra uma [Issue](https://github.com/gabriel-braoio/petshope/issues) para relatar problemas
2. Envie um [Pull Request](https://github.com/gabriel-braoio/petshope/pulls) com suas melhorias

---

**Desenvolvido com ❤️ em C# para aprender e evoluir**
