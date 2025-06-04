# 🛰️ ARYA .NET - Backend da Rede Inteligente de Drones

Este repositório contém o backend da solução **ARYA (Aerial Relief for Yielding Aid)**, uma rede aérea inteligente de drones voltada ao atendimento de áreas afetadas por desastres ambientais. O projeto foi desenvolvido em .NET utilizando Clean Architecture para garantir organização, escalabilidade e facilidade de manutenção.

---

## 📌 Descrição do Projeto

O ARYA .NET é o núcleo da aplicação, responsável por:

- Gerenciar entidades como drones, centros de controle e zonas de desastre;
- Expor endpoints RESTful para operações CRUD;
- Fornecer uma estrutura escalável e testável baseada em princípios da Clean Architecture;
- Integrar com bancos de dados relacionais;
- Facilitar a comunicação com outros módulos da solução (como aplicativos mobile ou dashboards administrativos).

---

## 🛠️ Tecnologias Utilizadas

- **.NET 8.0**
- **ASP.NET Core Web API**
- **Entity Framework Core**
- **MediatR**
- **AutoMapper**
- **FluentValidation**
- **Swagger (Swashbuckle)**
- **xUnit** (testes automatizados)
- **Clean Architecture**
- **SQL Server**

---

## 📂 Estrutura do Projeto

```plaintext
arya-dotnet/
├── Arya/                → Projeto principal da API ASP.NET Core
├── Arya.Domain/         → Entidades e interfaces do domínio
├── Arya.Application/    → Casos de uso e regras de negócio
├── Arya.Contracts/      → DTOs e contratos de dados
├── Arya.Infraestructure/→ Acesso a dados e integrações externas
├── Arya.Ioc/            → Configurações de Injeção de Dependência
├── Arya.Tests/          → Testes unitários (xUnit)
```

## 🚀 Como Executar o Projeto
### ✅ Pré-requisitos
- **.NET SDK 8.0**

- **SQL Server**

- **Editor de código (ex: Visual Studio, VS Code)**

📦 Passos para rodar localmente
Clone o repositório:

```bash
git clone https://github.com/ARYA-GS/arya-dotnet.git
```
```bash
cd arya-dotnet
```

Configure a string de conexão no arquivo Arya/appsettings.json:


```json
"ConnectionStrings": {
  "DefaultConnection": "Server=SEU_SERVIDOR;Database=ARYA;Trusted_Connection=True;"
}
```
### Aplique as migrações do banco:

```bash
dotnet ef database update --project Arya.Infraestructure
```

### Execute o projeto principal:

```bash
dotnet run --project Arya
```

### Acesse o Swagger no navegador:

```bash
https://localhost:5001/swagger
```

## 📚 Documentação dos Endpoints

A API é totalmente documentada via Swagger. Ao iniciar a aplicação, acesse:

```bash
https://localhost:5001/swagger
```
### Exemplos de endpoints:
| Método | 	Rota	| Descrição| 
|--------|----------|----------|
| GET	| `/api/drones`	| Listar todos os drones
| POST	| `/api/drones`	| Criar um novo drone
| PUT	| `/api/drones/{id}`	| Atualizar drone existente
| DELETE | `/api/drones/{id}`	| Remover drone
| GET	| `/api/zonas`	| Listar zonas de desastre
| POST	| `/api/centros-de-controle`	| Criar centro de controle


### ⚠️ A lista completa está disponível no Swagger.

### 🧪 Instruções de Testes
Acesse o diretório de testes:

```bash
cd Arya.Tests
```

Execute os testes com o seguinte comando:

```bash
dotnet test
```

```bash
dotnet test /p:CollectCoverage=true
```


👥 Contribuidores
| Nome | RM |
|------|----|
| Vitor Cruz dos Santos| 	RM553621
| Keven Ike Pereira da Silva | 	RM553215
| José Ribeiro dos Santos Neto | 	RM553844



📄 Licença
Este projeto é feito em parceira com a FIAP, projeto realizado para a Global Solution - 2025