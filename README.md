<h1>🏥 Clinic-API</h1>

<p>API REST para gerenciamento de consultas de uma clínica médica, desenvolvida com foco em modelagem de domínio e operações CRUD.</p>

<h2>📌 Sobre o Projeto</h2>

<p>A Clinic-API é uma solução backend para gerenciamento completo de consultas médicas. A API permite o cadastro e gerenciamento de pacientes, médicos, especialidades e consultas, oferecendo uma base sólida para integração com aplicações frontend.</p>

<h2>🛠️ Funcionalidades</h2>

<ul>
  <li><strong>CRUD completo</strong> para:
    <ul>
      <li>Consultas médicas</li>
      <li>Pacientes</li>
      <li>Profissionais (médicos)</li>
      <li>Especialidades</li>
    </ul>
  </li>
  <li>Relacionamento entre entidades</li>
  <li>API RESTful com endpoints padronizados</li>
</ul>

<h2>🏗️ Arquitetura</h2>

<ul>
  <li><strong>Controllers:</strong> Endpoints da API</li>
  <li><strong>Models/Entities:</strong> Representação das entidades</li>
  <li><strong>Data:</strong> Contexto do banco de dados e configurações do Entity Framework</li>
  <li><strong>Repositories (opcional):</strong> Camada de acesso a dados (se implementado)</li>
</ul>

<h2>💻 Tecnologias utilizadas</h2>
<ul>
  <li>C# 10</li>
  <li>.NET 6.0</li>
  <li>Entity Framework 7.0.11</li>
  <li>SQL Server</li>
</ul>

<h2>🚀 Como Executar o Projeto</h2>

<h3>📋 Pré-requisitos</h3>

<p>Antes de começar, certifique-se de ter instalado em sua máquina:</p>

<ul>
  <li><a href="https://dotnet.microsoft.com/pt-br/download">.NET 6.0 SDK</a> (compatível com o projeto)</li>
  <li><a href="https://www.microsoft.com/pt-br/sql-server/sql-server-downloads">SQL Server</a></li>
</ul>

<h3>⚙️ Configuração e Execução</h3>

<h4>1. Clone o repositório</h4>

<pre><code>git clone https://github.com/ArthurSantos18/Clinic-API.git
cd Clinic-API</code></pre>

<h4>2. Configurar a string de conexão</h4>

<p>No arquivo <code>appsettings.json</code>, atualize a propriedade <code>Database</code> com os dados do seu SQL Server:</p>

<pre><code>{
  "ConnectionStrings": {
    "Database": "Server=SEU_SERVIDOR;Database=ClinicAPI;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=True"
  }
</code></pre>
  
<h4>3. Aplicar as migrações do banco de dados</h4>
<pre><code>dotnet ef database update</code></pre>

<h4>4. Executar a API</h4>
<pre><code>dotnet run</code></pre>

<h2>📎 Links</h2>

<p>
  <a href="https://www.linkedin.com/in/arthurazevedo18">🔗 LinkedIn: Arthur Azevedo</a>
</p>

<h2>📄 Licença</h2>

<p>Este projeto foi desenvolvido para fins de estudo e portfólio profissional.</p>
