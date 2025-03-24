# BookStore - Sistema de Gerenciamento de Livros (WIP)

O BookStore é uma aplicação Full Stack para gerenciamento de livros em uma biblioteca virtual. A aplicação permite o cadastro, edição, listagem e remoção de livros, com backend em .NET e frontend em Angular.

## 📦 Tecnologias Utilizadas

### Backend
- .NET 8
- ASP.NET Core Web API
- Entity Framework Core
- SQLite
- Swagger

### Frontend
- Angular
- TypeScript
- Bootstrap
- RxJS

## 📁 Estrutura do Projeto

```
BookStore-main/
├── back/                        # Backend em .NET 8
│   ├── Controllers/
│   ├── Data/
│   ├── Migrations/
│   └── Models/
└── front/bookStore-App/         # Frontend em Angular
    ├── src/
    └── public/
```

## ⚙️ Como Executar

### Backend

1. Acesse a pasta `back/`:

```bash
cd back
```

2. Rode a aplicação:

```bash
dotnet run
```

A API estará disponível em `https://localhost:5001/swagger`.

### Frontend

1. Acesse a pasta do frontend:

```bash
cd front/bookStore-App
```

2. Instale as dependências:

```bash
npm install
```

3. Rode a aplicação:

```bash
ng serve
```

Acesse em `http://localhost:4200`.

## 🔄 Funcionalidades

- Listagem de livros
- Cadastro de novos livros
- Edição de informações
- Exclusão de livros
- Interface web amigável

## 📄 Licença

Projeto educacional de código aberto.
