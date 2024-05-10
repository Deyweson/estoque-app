# Estoque App


Desenvolvido em C# através do Visual Studio e utilizando WinForms .NET Framework, este aplicativo é um gerenciador de estoque simples e eficaz. Para emular a funcionalidade de um banco de dados, criei dois modelos essenciais: Produto e Movimentações. Além disso, para simular o armazenamento dos dados, elaborei um repositório que opera em memória, empregando listas para gerenciar tanto os produtos quanto suas movimentações.

![[Pasted image 20240510122253.png]]

## Detalhes do Sistema

### Adicionar um Produto

![[Pasted image 20240510121925.png]]

Nesta tela, é possível cadastrar um novo produto inserindo seu nome e clicando no botão "Adicionar Produto".

### Lista de Produtos

![[Pasted image 20240510122205.png]]

Aqui, à esquerda, é apresentada uma lista dos produtos cadastrados, exibindo seus IDs.

### Produto Selecionado e Seu Estoque

![[Pasted image 20240510122749.png]]

No centro da tela, são exibidos o ID e o nome do produto selecionado, juntamente com seu estoque atual.

### Operações de Entrada e Saída de Produtos

![[Pasted image 20240510122916.png]]

Nesta área central, é possível realizar operações de entrada e saída de produtos. O campo "Quant." permite inserir a quantidade da operação, enquanto o campo "Tipo" determina se é uma entrada ou saída. Há também um espaço para adicionar uma descrição da operação e um botão para confirmar a operação.

### Histórico de Operações

![[Pasted image 20240510124113.png]]

Nesta tabela, são listadas as operações do produto selecionado, mostrando o ID da operação, o tipo (entrada/saída), a quantidade, a data e uma descrição da operação.