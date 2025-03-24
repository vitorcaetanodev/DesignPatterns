# Design Patterns em Programação

Este repositório contém exemplos e explicações sobre os principais padrões de projetos utilizados no desenvolvimento de software. Os padrões de projeto são soluções reutilizáveis para problemas comuns encontrados no design de software.

## 📌 O que são Design Patterns?
Design Patterns (Padrões de Projeto) são soluções documentadas para problemas recorrentes no desenvolvimento de software. Eles ajudam a tornar o código mais reutilizável, escalável e de fácil manutenção.

---

## 📖 Padrões GOF (Gang of Four)
Os padrões de projeto foram popularizados pelos autores Erich Gamma, Richard Helm, Ralph Johnson e John Vlissides no livro "Design Patterns: Elements of Reusable Object-Oriented Software". Eles são conhecidos como os "Gang of Four" (GOF) e classificaram os padrões em três categorias principais:

- **Padrões Criacionais**: Relacionados à criação de objetos.
- **Padrões Estruturais**: Relacionados à composição de classes e objetos.
- **Padrões Comportamentais**: Relacionados à interação e comunicação entre objetos.

Esses padrões são amplamente utilizados na engenharia de software e servem como base para o desenvolvimento de arquiteturas robustas e flexíveis.

---

## 🏗️ Tipos de Padrões de Projeto
Os padrões são geralmente classificados em três categorias principais:

### 1️⃣ **Padrões Criacionais**
Os padrões criacionais tratam da criação de objetos, garantindo que a instância seja criada da forma mais adequada para a situação.

- **Singleton** – Garante que uma classe tenha apenas uma instância e fornece um ponto de acesso global a ela.
- **Factory Method** – Define uma interface para criar um objeto, mas permite que as subclasses alterem o tipo de objeto que será criado.
- **Abstract Factory** – Permite criar famílias de objetos relacionados sem especificar suas classes concretas.
- **Builder** – Separa a construção de um objeto complexo da sua representação, permitindo diferentes representações do mesmo processo de construção.
- **Prototype** – Permite criar novos objetos copiando uma instância existente.

### 2️⃣ **Padrões Estruturais**
Os padrões estruturais tratam da composição de classes e objetos, garantindo que os componentes do sistema funcionem juntos.

- **Adapter** – Permite que classes incompatíveis trabalhem juntas através de uma interface intermediária.
- **Bridge** – Separa uma abstração de sua implementação, permitindo que ambas sejam desenvolvidas independentemente.
- **Composite** – Permite que objetos sejam organizados em estruturas de árvore para representar hierarquias do tipo "todo-parte".
- **Decorator** – Adiciona funcionalidades a objetos de maneira dinâmica, sem alterar sua estrutura base.
- **Facade** – Fornece uma interface unificada para um conjunto de interfaces em um subsistema.
- **Flyweight** – Minimiza o uso de memória compartilhando objetos semelhantes.
- **Proxy** – Controla o acesso a um objeto, permitindo funcionalidades como lazy loading, controle de acesso e logging.

### 3️⃣ **Padrões Comportamentais**
Os padrões comportamentais tratam da comunicação e interação entre objetos.

- **Chain of Responsibility** – Permite que uma solicitação seja processada por uma sequência de manipuladores.
- **Command** – Encapsula uma solicitação como um objeto, permitindo o armazenamento e execução posterior.
- **Interpreter** – Define uma gramática para interpretar sentenças em uma linguagem específica.
- **Iterator** – Fornece uma maneira de acessar sequencialmente os elementos de uma coleção sem expor sua estrutura subjacente.
- **Mediator** – Define um objeto que centraliza a comunicação entre outros objetos para reduzir dependências.
- **Memento** – Permite restaurar o estado anterior de um objeto sem expor sua implementação interna.
- **Observer** – Define uma dependência um-para-muitos entre objetos, onde mudanças em um objeto notificam automaticamente os inscritos.
- **State** – Permite que um objeto altere seu comportamento quando seu estado interno muda.
- **Strategy** – Define uma família de algoritmos e os torna intercambiáveis sem alterar o código cliente.
- **Template Method** – Define a estrutura de um algoritmo, deixando a implementação de certos passos para subclasses.
- **Visitor** – Permite adicionar novas operações a uma estrutura de classes sem modificar suas implementações.

---

## 🛠️ Como Usar este Repositório
Este repositório contém exemplos de cada padrão de projeto em diferentes linguagens de programação. Você pode navegar pelos diretórios correspondentes e estudar os exemplos fornecidos.

1. Clone o repositório:
   ```bash
   git clone https://github.com/seu-usuario/design-patterns.git
   ```
2. Navegue para o diretório desejado e explore os exemplos:
   ```bash
   cd design-patterns
   ```

---

## 📚 Referências
- "Design Patterns: Elements of Reusable Object-Oriented Software" – Erich Gamma, Richard Helm, Ralph Johnson, John Vlissides.
- "Head First Design Patterns" – Eric Freeman, Elisabeth Robson.
- Documentação oficial de linguagens como Java, C#, Python e JavaScript.

---

## 📩 Contribuição
Sinta-se à vontade para contribuir com este repositório! Caso tenha sugestões ou novos exemplos, abra um pull request ou crie uma issue.

---

## 🏆 Licença
Este projeto está sob a licença MIT. Sinta-se à vontade para usar e modificar conforme necessário.

